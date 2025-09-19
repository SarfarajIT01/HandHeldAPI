using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryRecipeDesc
{
    public string? ItemCode { get; set; }

    public int? Sno { get; set; }

    public string? SubItem { get; set; }

    public string? SubItemDesc { get; set; }

    public string? SubItemUom { get; set; }

    public double? SubItemRate { get; set; }

    public double? SubItemQty { get; set; }

    public string? LocCode { get; set; }

    public string? Remark { get; set; }

    public double? LossQty { get; set; }

    public double? SubItemAmount { get; set; }
}
