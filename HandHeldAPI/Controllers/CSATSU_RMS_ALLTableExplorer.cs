using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSATSU_RMS_ALLTableExplorerController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_ALLTableExplorerController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("{OutletId}")]
        public async Task<ActionResult<AllTableExplorer>> GetAllTableExplorer(string OutletId)
        {
            try
            {
                var all = new AllTableExplorer();

                //  Occupied Tables
                var occupiedData = await (
                    from a in _context.PfbRkotTrns
                    join b in _context.PfbRkotSums on a.RkotNo equals b.RsumKot
                    where b.RsumSts == "K" && b.OutletId == OutletId
                    orderby b.RsumTbl
                    select new
                    {
                        a.RkotSubItem,
                        a.RkotIsaddon,
                        a.RkotModifier,
                        a.RkotPop,
                        a.OutletId,
                        b.RsumTim,
                        a.RkotNo,
                        a.RkotSno,
                        b.RsumTbl,
                        b.RsumStw,
                        b.RsumCvr,
                        b.RsumAmt,
                        a.RkotQty,
                        a.RkotRat,
                        a.RkotRem,
                        a.RkotMnu,
                        Name = _context.PfbMenuitemMasters
                            .Where(m => m.ItemCode == a.RkotMnu)
                            .Select(m => m.Descript)
                            .FirstOrDefault()
                    }
                ).ToListAsync();

                var occupiedList = new List<OccupiedTableExplorer>();

                foreach (var dr in occupiedData)
                {
                    var obj = new OccupiedTableExplorer
                    {
                        RkotPop = dr.RkotPop,
                        OutletId = dr.OutletId,
                        RsumTim = dr.RsumTim,
                        RkotNo = dr.RkotNo,
                        RsumTbl = dr.RsumTbl,
                        RsumStw = dr.RsumStw,
                        RsumCvr = dr.RsumCvr.ToString(),
                        RsumAmt = dr.RsumAmt?.ToString(),
                        //RkotQty = dr.RkotQty?.ToString(),
                        RkotQty = Convert.ToInt32(dr.RkotQty ?? 0).ToString(),
                        RkotRat = dr.RkotRat?.ToString(),
                        ItemName = dr.Name,
                        RkotRem = dr.RkotRem,
                        Amount = dr.RsumAmt?.ToString()
                    };

                    // Addon Handling
                    if (string.IsNullOrEmpty(obj.ItemName) && dr.RkotIsaddon == "y")
                    {
                        obj.ItemName = await _context.PfbRmnuAddons
                            .Where(a => a.RmnuAddonCod == dr.RkotMnu)
                            .Select(a => a.RmnuAddonStd)
                            .FirstOrDefaultAsync();
                    }

                    // Group Sub Item Handling
                    if (dr.RkotSubItem == "y")
                    {
                        var subName = await (
                            from a in _context.PfbSubItemTrns
                            join b in _context.PfbSubItems on a.RkotSubitem equals b.Id
                            where a.RkotMnu == dr.RkotMnu
                               && a.RkotNo == dr.RkotNo
                               && a.RkotPop == dr.RkotPop
                            select b.SubName
                        ).FirstOrDefaultAsync();

                        if (!string.IsNullOrEmpty(subName))
                            obj.ItemName = $"{obj.ItemName}-{subName}";
                    }

                    // Modifier Handling
                    if (!string.IsNullOrEmpty(dr.RkotModifier))
                    {
                        var desc = await _context.PfbRkotMen
                            .Where(x => x.Pos == dr.RkotPop &&
                                        x.Kotno == dr.RkotNo &&
                                        x.RkotSno == dr.RkotSno &&
                                        x.DesOrrem == "D")
                            .Select(x => x.Desci)
                            .FirstOrDefaultAsync();

                        if (!string.IsNullOrEmpty(desc))
                        {
                            obj.ItemName = desc;

                            var remark = await _context.PfbRkotMen
                                .Where(x => x.Pos == dr.RkotPop &&
                                            x.Kotno == dr.RkotNo &&
                                            x.RkotSno == dr.RkotSno &&
                                            x.DesOrrem == "R")
                                .Select(x => x.Desci)
                                .FirstOrDefaultAsync();

                            obj.RkotRem = remark ?? "";
                        }
                    }

                    occupiedList.Add(obj);
                }

                all.Occupied = occupiedList;

                // Vacant Tables
                var vacantTables = await _context.PfbRmscMsts
                    //.Where(t => (t.RmscTyp == "tbl" || t.RmscTyp == "rom") && t.RmscTblsts == "")
                    .Where(t => (t.RmscTyp == "tbl" || t.RmscTyp == "rom") && t.OutletId == OutletId)
                    .OrderBy(t => t.RmscCod)
                    .Select(t => new VacantTableExplorer
                    {
                        TableNo = t.RmscStd,
                        Status = t.RmscStatus
                    })
                    .ToListAsync();

                all.Vacant = vacantTables;

                return Ok(all);
            }
            catch (Exception ex)
            {
                // optional: log error
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

