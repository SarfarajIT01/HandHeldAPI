using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGlobalRefnoSetup
{
    public string? MasterTrnType { get; set; }

    public string? RefType { get; set; }

    public string? Refno { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? Flag { get; set; }

    public string? Remarks { get; set; }
}
