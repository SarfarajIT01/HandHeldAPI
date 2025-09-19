using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqConsumptionOrderQty
{
    public string? ResNo { get; set; }

    public string? ItemCode { get; set; }

    public double? Qty { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Flag { get; set; }
}
