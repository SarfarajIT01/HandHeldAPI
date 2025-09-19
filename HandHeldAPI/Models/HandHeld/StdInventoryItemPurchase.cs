using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItemPurchase
{
    public string ItemCode { get; set; } = null!;

    public string? OutletId { get; set; }

    public string? PUom { get; set; }

    public double? ItemCost { get; set; }

    public double? MPqty { get; set; }

    public string? LeadTime { get; set; }

    public short? OrderFreqDays { get; set; }

    public short? AvgDailyUsage { get; set; }

    public string? PTaxStruCode { get; set; }
}
