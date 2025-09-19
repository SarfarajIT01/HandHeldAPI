using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCompVisit
{
    public string? OutletId { get; set; }

    public string? CompCode { get; set; }

    public DateTime? VisitDate { get; set; }

    public string? VisitTime { get; set; }

    public string? VisitBillNo { get; set; }

    public double? VisitBillAmt { get; set; }

    public string? VisitRemark { get; set; }
}
