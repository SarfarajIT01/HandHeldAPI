using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCompanyugroup
{
    public string GrDesc { get; set; } = null!;

    public short GrCode { get; set; }

    public string? GrRemark { get; set; }

    public string? GrSts { get; set; }

    public string? GrLvl { get; set; }

    public string? GrAutoformat { get; set; }
}
