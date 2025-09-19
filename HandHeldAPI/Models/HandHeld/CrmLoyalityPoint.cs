using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmLoyalityPoint
{
    public string? OutletId { get; set; }

    public string? PointType { get; set; }

    public string? PRefno { get; set; }

    public string? GcFlag { get; set; }

    public string? GuestId { get; set; }

    public DateTime? PDate { get; set; }

    public string? AmFlag { get; set; }

    public string? Remarks { get; set; }

    public double? Points { get; set; }

    public string? CardNo { get; set; }
}
