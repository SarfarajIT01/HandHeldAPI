using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmLoyalitySetupDate
{
    public string? ModCode { get; set; }

    public DateTime? Fdate { get; set; }

    public DateTime? Tdate { get; set; }

    public double? Famount { get; set; }

    public double? Tamount { get; set; }

    public double? Points { get; set; }

    public double? BasePoint { get; set; }

    public double? Pointper { get; set; }

    public double? MinPoint { get; set; }

    public double? NoOfpoints { get; set; }

    public double? EqualCurr { get; set; }

    public string? Disc { get; set; }

    public string? OutletId { get; set; }
}
