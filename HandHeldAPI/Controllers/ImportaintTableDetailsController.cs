using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImportaintTableDetailsController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public ImportaintTableDetailsController(HandHeldDbContext context)
        {
            _context = context;
        }

        // -------------------- GET FOR OPEN TABLES --------------------
        [HttpGet("GetByID/{tableNo}/{pos}/{flag}")]
        public async Task<ActionResult<importaintTableDetail>> GetByID(string tableNo, string pos, string flag)
        {
            try
            {
                var query = _context.PfbRkotSums.AsQueryable();

                if (flag == "O")
                {
                    query = query.Where(r => r.RsumKot == tableNo && r.RsumSts == "K");
                }
                else if (flag == "B")
                {
                    query = query.Where(r => r.RsumBil == tableNo && r.RsumSts == "K");
                }
                else
                {
                    query = query.Where(r => r.RsumTbl == tableNo && r.RsumSts == "K");
                }

                var record = await query.FirstOrDefaultAsync();
                if (record == null)
                    return NotFound();

                var detail = new importaintTableDetail
                {
                    RSUM_KOT = record.RsumKot,
                    RSUM_DAT = record.RsumDat ?? DateTime.MinValue,
                    RSUM_TBL = record.RsumTbl,
                    RSUM_CVR = record.RsumCvr,
                    RSUM_TIM = record.RsumTim,
                    RSUM_TYP = record.RsumTyp,
                    RSUM_CSH = record.RsumCsh,
                    RSUM_STW = record.RsumStw?.ToString(),
                };

                // Get Bill Prefix (NextBill) - CORRECTED VERSION
                var nextBill = await (
                    from series in _context.PfbSeriesMsts
                    where series.SerNo == (
                          from igpos in _context.PfbIgposMsts
                          where igpos.GrpCod == (
                                from rmnu in _context.PfbMenuitemMasters
                                where rmnu.ItemCode == (
                                    from trn in _context.PfbRkotTrns
                                    where trn.RkotNo == (
                                        from sum in _context.PfbRkotSums
                                        where sum.RsumPop == pos && sum.RsumTbl == tableNo && sum.RsumSts == "K"
                                        select sum.RsumKot
                                    ).FirstOrDefault()
                                    select trn.RkotMnu  // ✅ CORRECTED: Get menu code from transaction
                                ).FirstOrDefault()
                                select rmnu.ItemGroup  // ✅ Get item group from menu master
                          ).FirstOrDefault()
                          && igpos.Pos == pos
                          && igpos.OdrbilType == "b"
                          select igpos.OdrbilSer
                    ).FirstOrDefault()
                    && series.Odrbil == "b"
                    && series.PosCode == pos
                    select series.CurNo
                ).FirstOrDefaultAsync();

                detail.NextBill = nextBill ?? "";
                return detail;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        // -------------------- GET FOR BILLED TABLES --------------------
        [HttpGet("GetBillByID/{tableNo}/{pos}")]
        public async Task<ActionResult<importaintTableDetail>> GetBillByID(string tableNo, string pos)
        {
            try
            {
                var record = await _context.PfbRkotSums
                    .Where(r => r.RsumTbl == tableNo && r.RsumSts == "B")
                    .FirstOrDefaultAsync();

                if (record == null)
                    return NotFound();

                var detail = new importaintTableDetail
                {
                    RSUM_KOT = record.RsumBil,
                    RSUM_DAT = record.RsumDat ?? DateTime.MinValue,
                    RSUM_TBL = record.RsumTbl,
                    RSUM_CVR = record.RsumCvr,
                    RSUM_TIM = record.RsumTim,
                    RSUM_TYP = record.RsumTyp,
                    RSUM_CSH = record.RsumCsh,
                    RSUM_STW = record.RsumStw?.ToString(),
                };

                // Get Bill Prefix (NextBill)
                var nextBill = await _context.PfbSeriesMsts
                    .Where(s => s.Odrbil == "B" && s.PosCode == pos)
                    .Select(s => s.CurNo)
                    .FirstOrDefaultAsync();

                detail.NextBill = nextBill ?? "";

                return detail;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
