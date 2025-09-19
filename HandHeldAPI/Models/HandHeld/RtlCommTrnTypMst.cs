using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlCommTrnTypMst
{
    public string? OutletId { get; set; }

    public string? TrnType { get; set; }

    public string? TrnDesc { get; set; }

    public string? RefNo { get; set; }

    public string? Header { get; set; }

    public string? Trailer { get; set; }

    public string? TrnFlag { get; set; }

    public string? PrintType { get; set; }

    public string? Code { get; set; }

    public string? RefFlag { get; set; }

    public string? PrintMode { get; set; }

    public string? RefNoSeries { get; set; }

    public string? TempType { get; set; }

    public string? LocCode { get; set; }
}
