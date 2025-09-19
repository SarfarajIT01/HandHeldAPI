using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDealsMst
{
    public string DiscCode { get; set; } = null!;

    public string? PosCode { get; set; }

    public string? DiscDesc { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public double? DiscVal { get; set; }

    public double? DiscPer { get; set; }

    public string? DiscAct { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public string? Remark { get; set; }

    public string? DiscOn { get; set; }

    public string? OutletId { get; set; }
}
