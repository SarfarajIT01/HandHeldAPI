namespace HandHeldAPI.Models.DTOs
{
    public class MenuItem
    {
        public string? ItemCode { get; set; }
        public string? PosCode { get; set; }
        public string? PosName { get; set; }
        public string? GroupName { get; set; }
        public string? GroupCode { get; set; }
        public string? MenuCatCode { get; set; }
        public string? ItemName { get; set; }
        public string? VegNonVeg { get; set; }
        public string? MenuCategory { get; set; }
        public string? MenuCategoryName { get; set; }
        public string? OutletId { get; set; }
        public float? Rates { get; set; }
        public DateTime? FromDate { get; set; }
        public string? TaxType { get; set; }
        public string? TaxStruCode { get; set; }
        public float? MinRate { get; set; }
        public float? MaxRate { get; set; }

        // Add a collection for sub-items
        public List<List<SubItem>> SubItems { get; set; } = new();
        public List<List<CommonAddon>> CommonAddons { get; set; } = new();

    }

    public class SubItem
    {
        public Int16? SubGrpId { get; set; }
        public string? SubitemNo { get; set; }
        public string? SubGrpName { get; set; }
        public string? SubItemName { get; set; }
        public float? SubItemRates { get; set; }
        public float? SubMinQty { get; set; }
        public float? SubMaxQty { get; set; }
    }

    public class CommonAddon
    {
        public Int16? SubGrpId { get; set; }
        public string? SubGrpName { get; set; }
        public string? SubItemName { get; set; }
        public float? SubItemRates { get; set; }
        public float? SubMinQty { get; set; }
        public float? SubMaxQty { get; set; }
    }
}





//namespace HandHeldAPI.Models.DTOs
//{
//    public class MenuItem
//    {
//        public string? ItemCode { get; set; }
//        public string? PosCode { get; set; }
//        public string? PosName { get; set; }
//        public string? GroupName { get; set; }
//        public string? GroupCode { get; set; }
//        public string? MenuCatCode { get; set; }
//        public string? ItemName { get; set; }
//        public string? VegNonVeg { get; set; }
//        public string? MenuCategory { get; set; }
//        public string? MenuCategoryName { get; set; }
//        public string? OutletId { get; set; }
//        public float? Rates { get; set; }
//        public DateTime? FromDate { get; set; }
//        public string? TaxType { get; set; }
//        public float? MinRate { get; set; }
//        public float? MaxRate { get; set; }

//        // Add a collection for sub-items
//        public List<SubItem> SubItems { get; set; } = new();
//        public Dictionary<string, List<CommonAdon>> CommonAdons { get; set; } = new();

//    }

//    public class SubItem
//    {
//        public Int16? SubGrpId { get; set; }
//        public string? SubGrpName { get; set; }
//        public string? SubItemName { get; set; }
//        public float? SubItemRates { get; set; }
//        public float? SubMinQty { get; set; }
//        public float? SubMaxQty { get; set; }
//    }

//    public class CommonAdon
//    {
//        public Int16? ComonAdonId { get; set; }
//        public string? ComonAdonName { get; set; }
//        public string? ComonItemName { get; set; }
//        public float? ComonItemRates { get; set; }
//        public float? ComonMinQty { get; set; }
//        public float? ComonMaxQty { get; set; }
//    }
//}


//namespace HandHeldAPI.Models.DTOs
//{
//    public class MenuItem
//    {
//        public string? ItemCode { get; set; }
//        public string? PosCode { get; set; }
//        public string? PosName { get; set; }
//        public string? GroupName { get; set; }
//        public string? GroupCode { get; set; }
//        public string? MenuCatCode { get; set; }
//        public string? ItemName { get; set; }
//        public string? VegNonVeg { get; set; }
//        public string? MenuCategory { get; set; }
//        public string? MenuCategoryName { get; set; }
//        public string? OutletId { get; set; }
//        public float? Rates { get; set; }
//        public DateTime? FromDate { get; set; }
//        public string? TaxType { get; set; }
//        public float? MinRate { get; set; }
//        public float? MaxRate { get; set; }
//        public List<SubItem> SubItems { get; set; } = new();
//        public Dictionary<string, List<CommonAdon>> CommonAdons { get; set; } = new();

//    }

//    public class SubItem
//    {
//        public Int16 SubGrpId { get; set; }
//        public string? SubGrpName { get; set; }
//        public string? SubItemName { get; set; }
//        public float? SubItemRates { get; set; }
//        public float MinQty { get; set; } = 0;
//        public float MaxQty { get; set; } = 1;
//    }

//    public class CommonAdon
//    {
//        public Int16 CommonAddonId { get; set; }
//        public string? CommonAddonName { get; set; }
//        public string? CommonItemName { get; set; }
//        public float? CommonItemRates { get; set; }
//        public float CommonMinQty { get; set; } = 0;
//        public float CommonMaxQty { get; set; } = 1;
//    }
//}