using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlDiscItem
{
    public string OutletId { get; set; } = null!;

    public string? PosCode { get; set; }

    public string? DiscCode { get; set; }

    public string? ItemCode { get; set; }

    public double? DiscPer { get; set; }

    public double? BilledQty { get; set; }

    public double? FreeQty { get; set; }

    public string? FreeItemCode { get; set; }

    public string? ItemFlag { get; set; }

    public double? DiscRate { get; set; }
}
