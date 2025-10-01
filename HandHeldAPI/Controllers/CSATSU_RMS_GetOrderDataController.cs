
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
    public class CSATSU_RMS_GetOrderDataController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_GetOrderDataController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("{tableNo}/{pos}")]
        public async Task<ActionResult<List<PfbRkotTrnDto>>> GetById(string tableNo, string pos)
        {
            try
            {
                // 🔹 Get Table Instruction
                var tableInstruction = await _context.PfbRmscMsts
                    .Where(r => r.RmscTyp == "TBL" && r.RmscPop == pos && r.RmscCod == tableNo)
                    .Select(r => r.RmscGlcode)
                    .FirstOrDefaultAsync();

                if (tableInstruction == null)
                    return NotFound("Table not found");

                // 🔹 Get Running Orders (RMS_RKOT_SUM)
                var runningOrders = await _context.PfbRkotSums
                    .Where(r => r.RsumTbl == tableNo && r.RsumSts == "K")
                    .ToListAsync();

                var results = new List<PfbRkotTrnDto>();

                foreach (var sum in runningOrders)
                {
                    // 🔹 Get all transactions for this order
                    var transactions = await _context.PfbRkotTrns
                        .Where(t => t.RkotNo == sum.RsumKot)
                        .ToListAsync();

                    foreach (var trn in transactions)
                    {
                        var obj = new PfbRkotTrnDto
                        {
                            RkotNo = trn.RkotNo,
                            RkotTyp = trn.RkotTyp,
                            RkotMnu = trn.RkotMnu,
                            TableInstruction = tableInstruction,
                            RsumStw = sum.RsumStw,
                            RsumCvr = sum.RsumCvr.ToString(),
                            RsumGcd = sum.RsumGcd,
                            RsumGcdName = sum.RsumGcdName
                        };

                        // 🔹 Get Item Details
                        var item = await _context.PfbMenuitemMasters
                            .FirstOrDefaultAsync(i => i.ItemCode == obj.RkotMnu);

                        if (item != null)
                        {
                            obj.ItemName = item.Descript;
                            obj.ItemCat = item.MenuCat;
                            obj.DiscountAllow = item.DiscAllow;
                            obj.ItemGroup = item.ItemGroup;
                        }

                        // 🔹 Copy values safely
                        obj.RkotRat = Math.Round(trn.RkotRat ?? 0, 2);
                        obj.RkotQty = Convert.ToInt32(trn.RkotQty ?? 0);  // ✅ Convert to integer
                        obj.RkotTax = Math.Round(trn.RkotTax ?? 0, 2);
                        obj.RkotSno = trn.RkotSno ?? 0;
                        obj.RkotDat = trn.RkotDat;
                        obj.RkotTaxtyp = trn.RkotTaxtyp;
                        obj.RkotRem = trn.RkotRem;
                        obj.RmnuRat = trn.RmnuRat ?? 0;
                        obj.RkotType = trn.RkotType;
                        obj.RkotDisc = trn.RkotDisc ?? 0;
                        obj.RkotPost = trn.RkotPost;
                        obj.RkotPrepTime = trn.RkotPrepTime;
                        obj.RkotPickTime = trn.RkotPickTime;
                        obj.RkotAddon = trn.RkotAddon;
                        obj.RkotServeTime = trn.RkotServeTime;
                        obj.RkotStax = trn.RkotStax ?? "GST5";
                        obj.RkotCombo = trn.RkotCombo;
                        obj.RkotIsaddon = trn.RkotIsaddon;
                        obj.RkotIsSerChgFree = trn.RkotIsSerChgFree;
                        obj.RkotSubItem = trn.RkotSubItem;
                        obj.RkotModifier = trn.RkotModifier;
                        obj.ComboCode = trn.ComboCode;
                        obj.ComboFlag = trn.ComboFlag;
                        obj.FnlBaseVal = Math.Round(trn.FnlBaseVal ?? 0, 2);
                        obj.DiscAmt = trn.DiscAmt ?? 0;
                        obj.RkotSurc = trn.RkotSurc ?? 0;
                        obj.RkotCvr = trn.RkotCvr;
                        obj.RkotMc = trn.RkotMc;
                        obj.DiscTyp = trn.DiscTyp;
                        obj.HhDisc = trn.HhDisc ?? 0;
                        //obj.GRP_SUB = trn.GrpSub;

                        // 🔹 Tax Calculation
                        //var tax = await _context.CsatcloudTaxstructureTrns
                        //    .Where(t => t.TaxStruCode == obj.RkotStax)
                        //    .SumAsync(t => (decimal?)Convert.ToDecimal (t.Factor));

                        //obj.RkotTax = tax;

                        // ==========================
                        // 🔹 SUBITEM + MODIFIER
                        // ==========================
                        if ((!string.IsNullOrWhiteSpace(trn.RkotSubItem)) || (!string.IsNullOrWhiteSpace(trn.RkotModifier)))
                        {
                            var subItem = await _context.PfbRkotMen
                                .Where(m => m.Kotno == trn.RkotNo &&
                                            m.Code == trn.RkotMnu &&
                                            m.RkotSno == trn.RkotSno &&
                                            m.DesOrrem == "D")
                                .FirstOrDefaultAsync();

                            if (subItem != null)
                            {
                                obj.ItemName = subItem.Desci;
                            }
                        }

                        // ==========================
                        // 🔹 GROUP SUBITEM
                        // ==========================
                        //if (trn.GrpSub == "y")
                        if (trn.RkotSubItem == "y")
                        {
                            var grpSubs = await (from a in _context.PfbSubItemTrns
                                                 join b in _context.PfbSubItems
                                                 on a.RkotSubitem equals b.Id
                                                 where a.RkotNo == trn.RkotNo && a.RkotSno == trn.RkotSno
                                                 select b.SubName).ToListAsync();

                            var commonAddons = await (from a in _context.PfbSubItemTrns
                                                      join b in _context.PfbCommonSubItems
                                                      on a.RkotSubitem equals b.Id
                                                      where a.RkotNo == trn.RkotNo && a.RkotSno == trn.RkotSno
                                                      select b.SubName).ToListAsync();

                            var allSubs = grpSubs.Concat(commonAddons).ToList();
                            if (allSubs.Any())
                            {
                                obj.GRPSubName = string.Join(", #", allSubs);
                            }
                        }

                        // ==========================
                        // 🔹 ADDON ITEMS
                        // ==========================
                        if (trn.RkotIsaddon == "y")
                        {
                            var addons = await (from b in _context.PfbRkotTrns
                                                join a in _context.PfbRmnuAddons
                                                    on b.RkotMnu equals a.RmnuAddonCod
                                                where a.RmnuCod == trn.RkotAddon &&
                                                      b.RkotIsaddon == "y" &&
                                                      b.RkotNo == trn.RkotNo &&
                                                      b.RkotSno == trn.RkotSno
                                                select a.RmnuAddonStd).ToListAsync();

                            if (addons.Any())
                            {
                                obj.ItemName = "##" + addons.First();
                            }
                        }

                        results.Add(obj);
                    }
                }

                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal error: {ex.Message}");
            }
        }
    }
}
