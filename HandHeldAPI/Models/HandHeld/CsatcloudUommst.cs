using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudUommst
{
    public string UomCode { get; set; } = null!;

    public string? UomDesc { get; set; }

    public short? UomDplace { get; set; }

    public string? UomSymbol { get; set; }

    public string? DsuCode { get; set; }

    public string? UomStatus { get; set; }
}
