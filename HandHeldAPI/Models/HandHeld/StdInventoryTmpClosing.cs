using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryTmpClosing
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public string? ItemUom { get; set; }

    public double? ItemQoh { get; set; }

    public double? ItemClsBal { get; set; }

    public double? ItemDiff { get; set; }

    public string? ItemRemark { get; set; }

    public string? SystemIp { get; set; }

    public string? Flag { get; set; }

    public string? LocCode { get; set; }
}
