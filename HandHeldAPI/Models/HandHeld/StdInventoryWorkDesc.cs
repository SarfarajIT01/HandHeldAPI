using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryWorkDesc
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public double? Qoh { get; set; }

    public double? OQty { get; set; }

    public string? DefSupp { get; set; }
}
