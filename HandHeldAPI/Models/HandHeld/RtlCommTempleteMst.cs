using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlCommTempleteMst
{
    public string? OutletId { get; set; }

    public string? TempType { get; set; }

    public string? Name { get; set; }

    public string? Header { get; set; }

    public string? Trailer { get; set; }

    public string? TrnType { get; set; }

    public string? ItemTemp { get; set; }

    public string? PrintMode { get; set; }

    public string? PrintType { get; set; }

    public string? RefNoSeries { get; set; }

    public string? PriceType { get; set; }

    public string? TTaxStruCode { get; set; }
}
