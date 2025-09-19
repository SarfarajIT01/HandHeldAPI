//using HandHeldAPI.Data;
//using HandHeldAPI.Models.DTOs;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace HandHeldAPI.Controllers
////namespace CSATSU_RMS.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CSATSU_RMS_ITEMSController : ControllerBase
//    {
//        private readonly HandHeldDbContext _context;

//        public CSATSU_RMS_ITEMSController(HandHeldDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<List<MenuItem>> GetMenuItemsWithRatesAsync(string outletId)
//        {
//            try
//            {
//                // Fetch main items
//                var mainItems = await (
//                    from a in _context.PfbMenuitemMasters
//                    join b in _context.PfbMenuRates on a.ItemCode equals b.ItemCode
//                    join c in _context.PfbOutletposMsts on b.Pos equals c.PosCode
//                    join d in _context.PfbIgroupMsts on a.ItemGroup equals d.GrpCod
//                    join e in _context.PfbRcuMsts on a.MenuCat equals e.RlocCod
//                    where a.Status == "A" && b.OutletId == outletId
//                    && (b.RmnuSubId == null || b.RmnuSubId == "")
//                    orderby a.ItemGroup, a.Descript
//                    select new MenuItem
//                    {
//                        ItemCode = a.ItemCode,
//                        ItemName = a.Descript,
//                        GroupCode = a.ItemGroup,
//                        MenuCategory = a.MenuCat,
//                        VegNonVeg = a.VegNonveg,
//                        MenuCatCode = a.MenuCat,
//                        PosCode = b.Pos,
//                        OutletId = b.OutletId,
//                        Rates = b.Rates,
//                        FromDate = b.FromDate,
//                        TaxType = b.TaxType,
//                        MinRate = b.MinRate,
//                        MaxRate = b.MaxRate,
//                        PosName = c.PosDesc,
//                        GroupName = d.GrpName,
//                        MenuCategoryName = e.CuDesc,
//                        SubItems = new List<SubItem>() // initialize
//                    }
//                ).Distinct().ToListAsync();

//                // Fetch sub-items
//                var groupSubItems = await (
//                    from a in _context.PfbMenuitemMasters
//                    join b in _context.PfbGrpSubItems on a.ItemCode equals b.ItemCode
//                    join c in _context.PfbSubItems on b.Id equals c.GrpId
//                    join d in _context.PfbMenuRates on c.Id equals d.RmnuSubId
//                    where a.GrpSubitem == "1"
//                          //&& d.OutletId == outletId
//                          && a.Status == "A"
//                          && (d.RmnuSubId != null || d.RmnuSubId != "")
//                    select new
//                    {
//                        a.ItemCode,
//                        d.Pos,
//                        SubGrpId = b.Id,
//                        SubGrpName = b.GrpName,
//                        SubItemName = c.SubName,
//                        SubItemRates = d.Rates,
//                        SubMinQty = b.MinQty,
//                        SubMaxQty = b.MaxQty
//                    }
//                ).ToListAsync();

//                // Attach sub-items to their parent items
//                foreach (var sub in groupSubItems)
//                {
//                    var parent = mainItems.FirstOrDefault(x => x.ItemCode == sub.ItemCode && x.PosCode == sub.Pos);
//                    if (parent != null)
//                    {
//                        parent.SubItems.Add(new SubItem
//                        {
//                            SubGrpId = sub.SubGrpId,
//                            SubGrpName = sub.SubGrpName,
//                            SubItemName = sub.SubItemName,
//                            SubItemRates = sub.SubItemRates,
//                            SubMinQty = sub.SubMinQty,
//                            SubMaxQty = sub.SubMaxQty
//                        });
//                    }
//                }

//                var commonAddonItems = await (
//                    from a in _context.PfbCommonItemAddonMappings
//                    join b in _context.PfbCommonGrpSubItems on a.GroupCode equals b.Id
//                    join c in _context.PfbCommonSubItems on b.Id equals c.GrpId
//                    join d in _context.PfbMenuRates on c.Id equals d.RmnuSubId
//                    where 
//                    //d.OutletId == outletId

//                           (d.RmnuSubId != null || d.RmnuSubId != "")
//                    select new
//                    {
//                        a.ItemCode,
//                        d.Pos,
//                        ComonAdonId = b.Id,
//                        ComonAdonName = b.GrpName,
//                        ComonItemName = c.SubName,
//                        ComonItemRates = d.Rates,
//                        ComonMinQty = b.MinQty,
//                        ComonMaxQty = b.MaxQty
//                    }
//                    ).ToListAsync();

//                // Attach sub-items to their parent items
//                foreach (var com in commonAddonItems)
//                {
//                    var parent = mainItems.FirstOrDefault(x => x.ItemCode == com.ItemCode && x.PosCode == com.Pos);
//                    if (parent != null)
//                    {
//                        parent.CommonAdons.Add(new CommonAdon
//                        {
//                            ComonAdonId = com.ComonAdonId,
//                            ComonAdonName = com.ComonAdonName,
//                            ComonItemName = com.ComonItemName,
//                            ComonItemRates = com.ComonItemRates,
//                            ComonMinQty = com.ComonMinQty,
//                            ComonMaxQty = com.ComonMaxQty
//                        });
//                    }
//                }
//                return mainItems;
//            }
//            catch (Exception)
//            {
//                return new List<MenuItem>();
//            }
//        }
//    }
//}

using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_ITEMSController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_ITEMSController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<MenuItem>> GetMenuItemsWithRatesAsync(string outletId)
        {
            try
            {
                // Fetch main items
                var mainItems = await (
                    from a in _context.PfbMenuitemMasters
                    join b in _context.PfbMenuRates on a.ItemCode equals b.ItemCode
                    join c in _context.PfbOutletposMsts on b.Pos equals c.PosCode
                    join d in _context.PfbIgroupMsts on a.ItemGroup equals d.GrpCod
                    join e in _context.PfbRcuMsts on a.MenuCat equals e.RlocCod
                    where a.Status == "A"
                          && b.OutletId == outletId
                          && (b.RmnuSubId == null || b.RmnuSubId == "")
                    orderby a.ItemGroup, a.Descript
                    select new MenuItem
                    {
                        ItemCode = a.ItemCode,
                        ItemName = a.Descript,
                        GroupCode = a.ItemGroup,
                        MenuCategory = a.MenuCat,
                        VegNonVeg = a.VegNonveg,
                        MenuCatCode = a.MenuCat,
                        PosCode = b.Pos,
                        OutletId = b.OutletId,
                        Rates = b.Rates,
                        FromDate = b.FromDate,
                        TaxType = b.TaxType,
                        MinRate = b.MinRate,
                        MaxRate = b.MaxRate,
                        PosName = c.PosDesc,
                        GroupName = d.GrpName,
                        MenuCategoryName = e.CuDesc,
                        TaxStruCode = b.RmnuTaxstrucode,
                        SubItems = new List<List<SubItem>>(),
                        CommonAddons = new List<List<CommonAddon>>()
                    }
                ).Distinct().ToListAsync();

                // Fetch sub-items
                var groupSubItems = await (
                    from a in _context.PfbMenuitemMasters
                    join b in _context.PfbGrpSubItems on a.ItemCode equals b.ItemCode
                    join c in _context.PfbSubItems on b.Id equals c.GrpId
                    join d in _context.PfbMenuRates on c.Id equals d.RmnuSubId
                    where a.GrpSubitem == "1"
                          && d.OutletId == outletId
                          && a.Status == "A"
                          && (d.RmnuSubId != null && d.RmnuSubId != "")
                    select new
                    {
                        a.ItemCode,
                        d.Pos,
                        SubGrpId = b.Id,
                        SubGrpName = b.GrpName,
                        SubItemName = c.SubName,
                        SubItemRates = d.Rates,
                        SubMinQty = b.MinQty,
                        SubMaxQty = b.MaxQty
                    }
                ).ToListAsync();

                // Attach sub-items grouped by SubGrpId
                foreach (var parent in mainItems)
                {
                    var subItemsForParent = groupSubItems
                        .Where(x => x.ItemCode == parent.ItemCode && x.Pos == parent.PosCode)
                        .GroupBy(x => x.SubGrpId)
                        .ToList();

                    foreach (var group in subItemsForParent)
                    {
                        var subGroupList = group.Select(sub => new SubItem
                        {
                            SubGrpId = sub.SubGrpId,
                            SubGrpName = sub.SubGrpName,
                            SubItemName = sub.SubItemName,
                            SubItemRates = sub.SubItemRates,
                            SubMinQty = sub.SubMinQty,
                            SubMaxQty = sub.SubMaxQty
                        }).ToList();

                        parent.SubItems.Add(subGroupList);
                    }
                }

                // Fetch common addons
                var commonAddonItems = await (
                    from a in _context.PfbCommonItemAddonMappings
                    join b in _context.PfbCommonGrpSubItems on a.GroupCode equals b.Id
                    join c in _context.PfbCommonSubItems on b.Id equals c.GrpId
                    join d in _context.PfbMenuRates on c.Id equals d.RmnuSubId
                    where
                          //d.OutletId == outletId
                          (d.RmnuSubId != null && d.RmnuSubId != "")
                    select new
                    {
                        a.ItemCode,
                        d.Pos,
                        SubGrpId = b.Id,
                        SubGrpName = b.GrpName,
                        SubItemName = c.SubName,
                        SubItemRates = d.Rates,
                        SubMinQty = b.MinQty,
                        SubMaxQty = b.MaxQty
                    }
                ).ToListAsync();

                // Attach common addons grouped by ComonAdonId
                foreach (var parent in mainItems)
                {
                    var addonsForParent = commonAddonItems
                        .Where(x => x.ItemCode == parent.ItemCode && x.Pos == parent.PosCode)
                        .GroupBy(x => x.SubGrpId)
                        .ToList();

                    foreach (var group in addonsForParent)
                    {
                        var addonGroupList = group.Select(sub => new CommonAddon
                        {
                            SubGrpId = sub.SubGrpId,
                            SubGrpName = sub.SubGrpName,
                            SubItemName = sub.SubItemName,
                            SubItemRates = sub.SubItemRates,
                            SubMinQty = sub.SubMinQty,
                            SubMaxQty = sub.SubMaxQty
                        }).ToList();

                        parent.CommonAddons.Add(addonGroupList);
                    }
                }

                return mainItems;
            }
            catch (Exception)
            {
                return new List<MenuItem>();
            }
        }
    }
}
