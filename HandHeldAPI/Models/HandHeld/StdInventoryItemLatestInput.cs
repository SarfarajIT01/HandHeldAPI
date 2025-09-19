using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItemLatestInput
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public string? TrnType { get; set; }

    public string? RefNo { get; set; }

    public DateTime? RefDate { get; set; }

    public double? QtyIn { get; set; }

    public double? QtyOut { get; set; }

    public double? InRate { get; set; }

    public string? LocCode { get; set; }

    public double? BalQty { get; set; }

    public double? AdjIn { get; set; }

    public double? AdjOut { get; set; }
}
