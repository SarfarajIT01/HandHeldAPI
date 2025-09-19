using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryTmpTrn
{
    public string? OutletId { get; set; }

    public string? ONo { get; set; }

    public string? ItemCode { get; set; }

    public double? OQty { get; set; }

    public double? BalanceQty { get; set; }

    public string? ItemLoc { get; set; }

    public string? TrnType { get; set; }

    public string? GrefNo { get; set; }

    public double? FbalQty { get; set; }
}
