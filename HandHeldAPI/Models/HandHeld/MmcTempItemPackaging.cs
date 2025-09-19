using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTempItemPackaging
{
    public string? PackageTrnType { get; set; }

    public string? PackageType { get; set; }

    public short? PackageLevel { get; set; }

    public string? ItemCode { get; set; }

    public string? PackagingItemUsed { get; set; }

    public float? PItemUsedWeight { get; set; }

    public double? PackItemQty { get; set; }

    public double? QtyofItem { get; set; }

    public double? Plength { get; set; }

    public double? Pwidth { get; set; }

    public double? Pheight { get; set; }

    public double? Pvolume { get; set; }

    public string? PackagingPtitle { get; set; }
}
