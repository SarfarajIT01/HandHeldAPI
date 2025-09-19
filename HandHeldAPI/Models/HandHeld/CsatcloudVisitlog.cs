using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudVisitlog
{
    public string OutletId { get; set; } = null!;

    public string? Module { get; set; }

    public string? GstCode { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? Amount { get; set; }
}
