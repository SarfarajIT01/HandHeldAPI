using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqSubItemMst
{
    public string SubItemCode { get; set; } = null!;

    public string? SubItemDesc { get; set; }

    public int? Quantity { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public short? Dorder { get; set; }

    public float? CostingQuantity { get; set; }

    public float? CostingRate { get; set; }

    public string? Remarks { get; set; }

    public string? AboutItem { get; set; }
}
