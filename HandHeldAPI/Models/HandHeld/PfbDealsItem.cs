using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDealsItem
{
    public string DiscCode { get; set; } = null!;

    public string? PosCode { get; set; }

    public string? ItemCode { get; set; }

    public string? SubCode { get; set; }

    public double? ItemRate { get; set; }

    public double? Qty { get; set; }

    public string? BgFlag { get; set; }

    public double? Disc { get; set; }

    public string? OutletId { get; set; }
}
