using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTempRecipeDesc
{
    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public int? Sno { get; set; }

    public string? SubItem { get; set; }

    public string? SubItemDesc { get; set; }

    public string? SubItemUom { get; set; }

    public double? SubItemQty { get; set; }

    public double? SubItemRate { get; set; }

    public double? Value { get; set; }

    public double? Uqty { get; set; }

    public double? Uvalue { get; set; }

    public string? MatDesc { get; set; }
}
