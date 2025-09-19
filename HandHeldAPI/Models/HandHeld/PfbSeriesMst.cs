using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbSeriesMst
{
    public string SerNo { get; set; } = null!;

    public string? OutletId { get; set; }

    public string? PosCode { get; set; }

    public string? OrderCode { get; set; }

    public string? Odrbil { get; set; }

    public string? CurNo { get; set; }

    public int? SkipDgt { get; set; }

    public string? Reset { get; set; }

    public string? Remark { get; set; }

    public string? MaxNo { get; set; }
}
