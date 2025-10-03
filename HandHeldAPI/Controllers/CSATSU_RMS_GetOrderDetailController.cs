using HandHeldAPI.Data;
using HandHeldAPI.Models;
using HandHeldAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_GetOrderDetailController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_GetOrderDetailController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("{orderNo}")]
        public async Task<ActionResult<IEnumerable<PfbRkotSumDto>>> GetById(string orderNo)
        {
            // 🔹 Fetch Order Summary (RMS_RKOT_SUM)
            var orderSummary = await _context.PfbRkotSums
                .Where(s => s.RsumKot == orderNo && s.RsumSts == "K")
                .ToListAsync();

            if (!orderSummary.Any())
                return NotFound("No items found for this OrderNo");

            var result = new List<PfbRkotSumDto>();

            foreach (var sum in orderSummary)
            {
                var sumDto = new PfbRkotSumDto
                {
                    RsumKot = sum.RsumKot,
                    OutletId = sum.OutletId,
                    RsumPop = sum.RsumPop,
                    RsumDat = sum.RsumDat,
                    RsumTbl = sum.RsumTbl,
                    RsumCvr = sum.RsumCvr,
                    RsumTim = sum.RsumTim,
                    RsumSts = sum.RsumSts,
                    RsumTyp = sum.RsumTyp,
                    RsumCsh = sum.RsumCsh,
                    RsumNo = sum.RsumNo,
                    RsumAmt = sum.RsumAmt,
                    itemdata = new List<PfbRkotTrnDto>()
                };

                // 🔹 Fetch Order Transactions (RMS_RKOT_TRN)
                var trns = await _context.PfbRkotTrns
                    .Where(t => t.RkotNo == sum.RsumKot)
                    .ToListAsync();

                foreach (var trn in trns)
                {
                    var trnDto = new PfbRkotTrnDto
                    {
                        RkotPop = trn.RkotPop,
                        RkotNo = trn.RkotNo,
                        RkotTyp = trn.RkotTyp,
                        RkotMnu = trn.RkotMnu,
                        RkotRat = trn.RkotRat,
                        RkotQty = trn.RkotQty,
                        RkotTax = trn.RkotTax,
                        RkotSno = trn.RkotSno,
                        RkotDat = trn.RkotDat,
                        RkotTaxtyp = trn.RkotTaxtyp,
                        RkotRem = trn.RkotRem,
                        RmnuRat = trn.RmnuRat,
                        RkotType = trn.RkotType,
                        RkotDisc = trn.RkotDisc,
                        RkotPost = trn.RkotPost,
                        RkotPrepTime = trn.RkotPrepTime,
                        RkotPickTime = trn.RkotPickTime,
                        RkotAddon = trn.RkotAddon,
                        RkotServeTime = trn.RkotServeTime,
                        RkotStax = trn.RkotStax,
                        RkotCombo = trn.RkotCombo,
                        RkotIsaddon = trn.RkotIsaddon,
                        RkotIsSerChgFree = trn.RkotIsSerChgFree,
                        RkotSubItem = trn.RkotSubItem,
                        RkotModifier = trn.RkotModifier,
                        ComboCode = trn.ComboCode,
                        ComboFlag = trn.ComboFlag,
                        FnlBaseVal = trn.FnlBaseVal,
                        DiscAmt = trn.DiscAmt,
                        RkotSurc = trn.RkotSurc,
                        RkotCvr = trn.RkotCvr,
                        RkotMc = trn.RkotMc,
                        DiscTyp = trn.DiscTyp,
                        HhDisc = trn.HhDisc,
                        GRPSubNameList = new List<string>(),
                        GRPsubGroupIDList = new List<string>()
                    };

                    // 🔹 Join with RMS_RMNU_MST (Menu Details)
                    var menu = await _context.PfbMenuitemMasters
                        .FirstOrDefaultAsync(m => m.ItemCode == trn.RkotMnu);

                    if (menu != null)
                    {
                        trnDto.ItemName = menu.Descript;
                        trnDto.VegNonveg = menu.VegNonveg;

                        var cat = await _context.PfbRcuMsts
                            .FirstOrDefaultAsync(c => c.RlocCod == menu.RmnuTouchCat);

                        if (cat != null)
                            trnDto.ItemCat = cat.CuDesc;

                        var grp = await _context.PfbIgroupMsts
                            .FirstOrDefaultAsync(g => g.GrpCod == menu.RmnuTyp);

                        if (grp != null)
                            trnDto.ItemGrp = grp.GrpName;
                    }

                    // 🔹 Addon handling
                    if (trn.RkotIsaddon == "y")
                    {
                        var addon = await _context.PfbRmnuAddons
                            .FirstOrDefaultAsync(a => a.RmnuAddonCod == trn.RkotMnu);

                        if (addon != null)
                        {
                            trnDto.ItemName = addon.RmnuAddonStd;
                            trnDto.UmeshSign = "Addon";
                        }
                    }

                    // 🔹 SubItem + Common SubItem
                    if (trn.GrpSub == "y")
                    {
                        var subItems = await (from a in _context.PfbSubItemTrns
                                              join b in _context.PfbSubItems on a.RkotSubitem equals b.Id
                                              where a.RkotNo == trn.RkotNo && a.RkotSno == trn.RkotSno
                                              select new { b.SubName, b.Id }).ToListAsync();

                        foreach (var sub in subItems)
                        {
                            trnDto.GRPSubNameList.Add(sub.SubName);
                            trnDto.GRPsubGroupIDList.Add(sub.Id.ToString());
                        }

                        var commonSubs = await (from a in _context.PfbSubItemTrns
                                                join b in _context.PfbCommonSubItems on a.RkotSubitem equals b.Id
                                                where a.RkotNo == trn.RkotNo && a.RkotSno == trn.RkotSno
                                                select new { b.SubName, b.Id }).ToListAsync();

                        foreach (var sub in commonSubs)
                        {
                            trnDto.GRPSubNameList.Add(sub.SubName);
                            trnDto.GRPsubGroupIDList.Add(sub.Id.ToString());
                        }
                    }

                    // 🔹 Modifier
                    if (!string.IsNullOrEmpty(trn.RkotModifier))
                    {
                        var modifier = await _context.PfbRkotMen
                            .Where(m => m.Pos == trn.RkotPop &&
                                        m.Kotno == trn.RkotNo &&
                                        m.RkotSno == trn.RkotSno &&
                                        m.DesOrrem == "D")
                            .Select(m => m.Desci)
                            .FirstOrDefaultAsync();

                        if (modifier != null)
                        {
                            trnDto.ItemName = modifier;
                            trnDto.UmeshSign = "Modifier";
                            trnDto.GRPsubGroupID = trn.RkotModifier;
                        }
                    }

                    sumDto.itemdata.Add(trnDto);
                }

                result.Add(sumDto);
            }

            return Ok(result);
        }
    }
}
