using HandHeldAPI.Data;
using HandHeldAPI.Models;
using HandHeldAPI.Models.DTOs;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSATSU_RMS_FinallBillGeneratorController : ControllerBase
    {
        private readonly HandHeldDbContext _context;
        private static readonly object _lock = new object();

        public CSATSU_RMS_FinallBillGeneratorController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<string>>> BillGenerate([FromBody] OrderDataDto obj)
        {
            List<string> result = new List<string>();

            lock (_lock)
            {
                try
                {
                    string pos = obj.pos.ToString();
                    DateTime now = DateTime.Now;
                    string timeHHmm = now.ToString("HH:mm");
                    string timeFull = now.ToString("HH:mm:ss");

                    // --- Get KOT Type for POS ---
                    string ktCode = _context.PfbSeriesMsts
                        .Join(_context.PfbOrderMasters,       //RmsKottypMsts,
                              a => a.OrderCode,
                              b => b.Otypecode,                  //Ktcode,
                              (a, b) => new { a, b })
                        .Where(x => x.a.PosCode == pos && x.b.Description == "guest")   //Ktdesc
                        .Select(x => x.b.Otypecode)
                        .FirstOrDefault() ?? "GUEST";

                    var orderNumbers = new Dictionary<string, string>();
                    var usedGroup = new Dictionary<string, string>();

                    if (obj.RKOT_TRN_DATA != null && obj.RKOT_TRN_DATA.Count > 0)
                    {
                        foreach (var item in obj.RKOT_TRN_DATA)
                        {
                            // Get Group Code (Serial Number)
                            var groupCode = (from g in _context.PfbIgposMsts
                                             join m in _context.PfbMenuitemMasters
                                             on g.GrpCod equals m.ItemGroup
                                             where m.ItemCode == item.ItemCode
                                                   && g.Pos == pos
                                                   && g.OdrbilType == "B"
                                             select g.OdrbilSer)
                                             .FirstOrDefault();

                            if (groupCode == null) continue;

                            string orderNo;
                            if (usedGroup.ContainsKey(groupCode))
                            {
                                orderNo = usedGroup[groupCode];
                                orderNumbers[item.ItemCode] = orderNo;
                            }
                            else
                            {
                                // Get current series number
                                var series = _context.PfbSeriesMsts
                                    .FirstOrDefault(s => s.SerNo == groupCode
                                                      && s.Odrbil == "B"
                                                      && s.PosCode == pos);

                                if (series == null)
                                {
                                    series = _context.PfbSeriesMsts
                                        .FirstOrDefault(s => s.SerNo == "B"
                                                          && s.Odrbil == "B"
                                                          && s.PosCode == pos);
                                }

                                if (series == null) continue;

                                orderNo = series.CurNo;
                                orderNumbers[item.ItemCode] = orderNo;
                                usedGroup[groupCode] = orderNo;

                                // Increment current series
                                string prefix = orderNo.Substring(0, 2);
                                string numericPart = orderNo.Substring(2);
                                int nextNo = int.Parse(numericPart) + 1;
                                string newNo = prefix + nextNo.ToString().PadLeft(numericPart.Length, '0');
                                series.CurNo = newNo;
                            }
                        }
                    }
                    string sysDate = _context.PfbMsts.Select(m => m.RmsStdate).FirstOrDefault()?.ToString("yyyy-MM-dd") ?? DateTime.Now.ToString("yyyy-MM-dd");
                    bool atLeastOneAffected = false;

                    foreach (var trn in obj.RKOT_TRN_DATA)
                    {
                        if (!orderNumbers.TryGetValue(trn.ItemCode, out string orderNo))
                            continue;

                        // Update RMS_RKOT_TRN
                        var rkotTrn = _context.PfbRkotTrns
                            .FirstOrDefault(t => t.RkotNo == trn.RKOT_NO &&
                                                 t.RkotMnu == trn.ItemCode &&
                                                 //t.RkotSno == trn.RKOT_SNO);
                                                 t.RkotSno == short.Parse(trn.RKOT_SNO));
                        if (rkotTrn != null)
                        {
                            rkotTrn.RkotDisc = decimal.Parse(trn.DiscountPer);
                        }

                        // Check if RMS_RBILL_SUM already exists
                        bool billExists = _context.PfbRbillSums.Any(b =>
                            b.RbilPop == pos &&
                            b.RbilTbl == obj.Tbl.ToString() &&
                            b.RbilNo == orderNo &&
                            b.RbilSts == "B");

                        if (billExists)
                        {
                            // Update KOT summary
                            var sum = _context.PfbRkotSums
                                .FirstOrDefault(s => s.RsumTbl == obj.Tbl.ToString()
                                                  && s.RsumSts == "K"
                                                  && s.RsumKot == trn.RKOT_NO);
                            if (sum != null)
                            {
                                sum.RsumSts = "B";
                                sum.RsumBil = orderNo;
                            }
                        }
                        else
                        {
                            // Calculate total for this serial
                            double serialAmt = (double)(_context.PfbRkotSums
                           .Where(s => s.RsumTbl == obj.Tbl.ToString()
                                    && s.RsumSts == "K"
                                    && s.RsumKot == trn.RKOT_NO)
                           .Select(s => s.RsumAmt)
                           .FirstOrDefault() ?? 0);

                            string currentGroupKey = usedGroup.FirstOrDefault(x => x.Value == orderNo).Key ?? "";

                            // TAX Insert
                            var taxes = obj.TaxStructure2
                                .Where(t => t.seriesFlag == currentGroupKey)
                                .ToList();

                            foreach (var tx in taxes)
                            {
                                _context.PfbRbillTaxes.Add(new PfbRbillTax
                                {
                                    RtaxPos = pos,
                                    RtaxDate = DateTime.Parse(sysDate),
                                    RtaxBill = orderNo,
                                    RtaxStcode = "",
                                    RtaxTcode = tx.RTax_TCode,
                                    //RtaxOnAmt = tx.RTax_OnAmt,
                                    //RtaxTaxAmt = tx.RTax_TaxAmt,
                                    RtaxOnAmt = (double)short.Parse(tx.RTax_OnAmt),
                                    RtaxTaxAmt = short.Parse(tx.RTax_TaxAmt),
                                    RtaxChg = "Y",
                                    RtaxRsn = "",
                                    RtaxTaxTyp = tx.RTax_TaxTyp
                                });
                            }

                            var lastTax = obj.TaxStructureGroupWise
                                .Where(t => t.seriesFlag == currentGroupKey)
                                .LastOrDefault();

                            if (lastTax != null)
                            {
                                serialAmt += double.Parse(lastTax.RTax_TaxAmt);
                                serialAmt = Math.Round(serialAmt);

                                var billSum = new PfbRbillSum
                                {
                                    RbilTcode = timeFull,
                                    RbilPop = pos,
                                    RbilDat = DateTime.Parse(sysDate),
                                    RbilNo = orderNo,
                                    RbilTbl = obj.Tbl.ToString(),
                                    RbilTim = timeHHmm,
                                    RbilTamt = decimal.Parse(lastTax.RBIL_TAMT),
                                    RbilNamt = decimal.Parse(lastTax.RBIL_NAMT),
                                    RbilTotal = decimal.Parse(lastTax.RBIL_TOTAL),
                                    RbilStx = decimal.Parse(lastTax.RBIL_STX),
                                    RbilOtx = decimal.Parse(lastTax.RBIL_OTX),
                                    RbilDc1 = decimal.Parse(lastTax.RBIL_DC1),
                                    RbilSts = "B",
                                    RbilTaxfree = obj.RBIL_TAXFREE,
                                    RbilRound = decimal.Parse(lastTax.RBIL_ROUND),
                                    RbilTaxableDisc = obj.RBIL_TaxableDisc,
                                    RbilCvchr2 = obj.RBIL_CVCHR2.ToString(),
                                    RbilRem = obj.odrem,
                                    RbilGcd = obj.G_Code,
                                    RbilGst = obj.G_Name
                                };

                                var trackedEntity = _context.ChangeTracker.Entries<PfbRbillSum>()
                                    .FirstOrDefault(e => e.Entity.RbilNo == orderNo)?.Entity;

                                if (trackedEntity == null)
                                {
                                    _context.PfbRbillSums.Add(billSum);
                                }
                                else
                                {
                                    // Optionally update trackedEntity's properties here if needed
                                }

                                // Update RMS_RKOT_SUM
                                var sum = _context.PfbRkotSums
                                    .FirstOrDefault(s => s.RsumTbl == obj.Tbl.ToString()
                                                      && s.RsumSts == "K"
                                                      && s.RsumKot == trn.RKOT_NO);
                                if (sum != null)
                                {
                                    sum.RsumSts = "B";
                                    sum.RsumBil = orderNo;
                                }

                                // Add Print Queue
                                //_context.PdaPrnqs.Add(new RmsPdaPrnq
                                //{
                                //    PosId = pos,
                                //    OrderBillNo = orderNo,
                                //    PrnFlag = "B"
                                //});

                                atLeastOneAffected = true;
                            }

                            
                        }
                    }

                    // Update Table Status
                    if (atLeastOneAffected)
                    {
                        var tbl = _context.PfbRmscMsts
                            .FirstOrDefault(t => t.RmscTyp == "TBL" && t.RmscCod == obj.Tbl.ToString());
                        if (tbl != null)
                        {
                            tbl.RmscTblsts = "P";
                            tbl.RmscGlcode = "";
                        }

                        result.Add(orderNumbers.Values.LastOrDefault() ?? "");
                    }
                    else
                    {
                        result.Add("Bill not Generated");
                    }

                    _context.SaveChanges();
                    return Ok(result);
                }
                catch (Exception)
                {
                    result.Add("Bill not Generated");
                    return Ok(result);
                }
            }
        }
    }
}
