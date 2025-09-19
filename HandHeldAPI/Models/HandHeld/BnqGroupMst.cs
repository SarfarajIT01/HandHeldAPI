using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqGroupMst
{
    public string GroupCode { get; set; } = null!;

    public string? GroupDesc { get; set; }

    public double? GroupRate { get; set; }

    public string? Remark { get; set; }

    public bool? RateRestricted { get; set; }

    public short? GrpPrntOrd { get; set; }
}
