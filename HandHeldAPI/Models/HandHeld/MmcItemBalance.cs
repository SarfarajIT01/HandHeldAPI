using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcItemBalance
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public double? ItRecMin { get; set; }

    public double? ItRecMax { get; set; }

    public double? ItIssMin { get; set; }

    public double? ItIssMax { get; set; }

    public short? OrderFreqDays { get; set; }

    public short? AvgDailyUsage { get; set; }
}
