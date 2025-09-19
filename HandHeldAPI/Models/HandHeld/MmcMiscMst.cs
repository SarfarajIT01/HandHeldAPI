using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcMiscMst
{
    public string MiscType { get; set; } = null!;

    public string? MiscFlag { get; set; }

    public string? MiscDesc { get; set; }

    public string? MiscStatus { get; set; }

    public string? MiscRemark { get; set; }

    public double? GtrnAmt { get; set; }

    public string? OutletId { get; set; }

    public string? LocCode { get; set; }
}
