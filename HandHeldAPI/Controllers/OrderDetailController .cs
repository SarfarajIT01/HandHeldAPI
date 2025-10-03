using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public OrderDetailController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("{orderNo}")]
        public async Task<ActionResult<List<PfbRkotSumDto>>> GetById(string orderNo)
        {
            try
            {
                // Fetch RMS_RKOT_SUM with status = K
                var summaries = await _context.PfbRkotSums
                    .Where(s => s.RsumKot == orderNo && s.RsumSts == "K")
                    .ToListAsync();

                if (!summaries.Any())
                    return NotFound("No records found");

                foreach (var sm in summaries)
                {
                    // Fetch transaction lines for this order
                    var transactions = await _context.PfbRkotTrns
                        .Where(t => t.RkotNo == sm.RsumKot)
                        .ToListAsync();

                    foreach (var obj in transactions)
                    {
                        // Get menu details
                        var menu = await _context.PfbMenuitemMasters
                            .FirstOrDefaultAsync(m => m.ItemCode == obj.RkotMnu);

                        if (menu != null)
                        {
                            obj.ItemName = menu.Descript;
                            obj.VegNonveg = menu.VegNonveg;
                            var catcode = menu.TouchCat;
                            var grpCode = menu.ItemGroup;

                            // Item Category
                            var category = await _context.PfbRcuMsts
                                .FirstOrDefaultAsync(c => c.RlocCod == catcode);
                            if (category != null)
                                obj.ItemCat = category.CuDesc;

                            // Item Group
                            var group = await _context.PfbIgroupMsts
                                .FirstOrDefaultAsync(g => g.GrpCod == grpCode);
                            if (group != null)
                                obj.ItemGrp = group.GrpName;
                        }

                        // Handle Addon
                        if (obj.RkotIsaddon == "y")
                        {
                            var addon = await _context.PfbRmnuAddons
                                .FirstOrDefaultAsync(a => a.RmnuAddonCod == obj.RkotMnu);
                            if (addon != null)
                            {
                                obj.ItemName = addon.RmnuAddonStd;
                                obj.UmeshSign = "Addonnnnn";
                                obj.AddonRate = "";
                            }
                        }

                        // Handle Sub Items (GRP_SUB)
                        if (obj.RkotSubItem == "y")
                        {
                            obj.UmeshSign = "GRPsub";
                            obj.GRPSubNameList = new List<string>();
                            obj.GRPsubGroupIDList = new List<string>();

                            // Sub Items
                            var subItems = await (from a in _context.PfbSubItemTrns
                                                  join b in _context.PfbSubItems
                                                  on a.RkotSubitem equals b.Id
                                                  where a.RkotNo == obj.RkotNo && a.RkotSno == obj.RkotSno
                                                  select new { b.SubName, b.Id }).ToListAsync();

                            foreach (var si in subItems)
                            {
                                obj.GRPSubNameList.Add(si.SubName);
                                obj.GRPsubGroupIDList.Add(si.Id.ToString());
                            }

                            // Common Sub Items
                            var commonSubs = await (from a in _context.PfbSubItemTrns
                                                      join b in _context.PfbCommonSubItems
                                                      on a.RkotSubitem equals b.Id
                                                      where a.RkotNo == obj.RkotNo && a.RkotSno == obj.RkotSno
                                                      select new { b.SubName, b.Id }).ToListAsync();
                          

                            foreach (var cs in commonSubs)
                            {
                                obj.GRPSubNameList.Add(cs.SubName);
                                obj.GRPsubGroupIDList.Add(cs.Id.ToString());
                            }
                        }

                        // Handle Modifier
                        if (!string.IsNullOrEmpty(obj.RkotModifier))
                        {
                            var modifier = await _context.PfbRkotMen
                                .Where(m => m.Pos == obj.RkotPop &&
                                            m.Kotno == obj.RkotNo &&
                                            m.RkotSno == obj.RkotSno &&
                                            m.DesOrrem == "D")
                                .FirstOrDefaultAsync();

                            if (modifier != null)
                            {
                                obj.ItemName = modifier.Desci;
                                obj.UmeshSign = "Modifier";
                                obj.GRPsubGroupID = obj.RKOT_Modifier;
                            }
                        }
                    }

                    sm.itemdata = transactions;
                }

                return Ok(summaries);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

       
    }
}

