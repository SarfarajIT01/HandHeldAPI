using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryGtaxMst
{
    public string? FlagType { get; set; }

    public string? Tcode { get; set; }

    public string? Tdesc { get; set; }

    public double? Tper { get; set; }

    public string? ExciseFlag { get; set; }

    public string? OtherFlag { get; set; }

    public string? LedgerCode { get; set; }

    public string? TrnitmFlag { get; set; }

    public string? Type { get; set; }

    public double? Factor { get; set; }
}
