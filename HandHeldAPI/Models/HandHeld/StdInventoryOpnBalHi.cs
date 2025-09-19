using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryOpnBalHi
{
    public string? OutletId { get; set; }

    public string? LocCode { get; set; }

    public DateTime? CDate { get; set; }

    public string? ItemCode { get; set; }

    public double? OldQty { get; set; }

    public double? OldRate { get; set; }

    public double? NewQty { get; set; }

    public double? NewRate { get; set; }
}
