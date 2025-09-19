using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqGuestComment
{
    public string? GCode { get; set; }

    public DateTime? GDov { get; set; }

    public DateTime? GTov { get; set; }

    public string? GBill { get; set; }

    public string? GVisitAs { get; set; }

    public string? GFov { get; set; }

    public string? GNegC { get; set; }

    public string? GPosC { get; set; }

    public string? GComment { get; set; }
}
