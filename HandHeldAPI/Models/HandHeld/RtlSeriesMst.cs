using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlSeriesMst
{
    public string? OutletId { get; set; }

    public string? PosCode { get; set; }

    public string? OrderCode { get; set; }

    public string? Odrbil { get; set; }

    public string? SerNo { get; set; }

    public string? CurNo { get; set; }

    public int? SkipDgt { get; set; }

    public string? Reset { get; set; }

    public string? Remark { get; set; }
}
