using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDenomCurr
{
    public string OutletId { get; set; } = null!;

    public short? DnSeq { get; set; }

    public string? DnLabel { get; set; }

    public double? DnVal { get; set; }

    public string? DnFlag { get; set; }

    public string? DnPic { get; set; }
}
