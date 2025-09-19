using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlDiscMst
{
    public string OutletId { get; set; } = null!;

    public string? PosCode { get; set; }

    public string? DiscCode { get; set; }

    public string? DiscDesc { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public string? DiscAct { get; set; }

    public string? DiscOgi { get; set; }

    public double? DiscFl { get; set; }

    public double? DiscTl { get; set; }

    public double? DiscPer { get; set; }

    public string? DiscFlag { get; set; }

    public string? DiscOpn { get; set; }
}
