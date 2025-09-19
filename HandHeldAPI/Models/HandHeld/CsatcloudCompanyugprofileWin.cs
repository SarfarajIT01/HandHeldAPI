using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCompanyugprofileWin
{
    public short GrCode { get; set; }

    public string ModuleId { get; set; } = null!;

    public string MenuValue { get; set; } = null!;

    public string? MenuText { get; set; }

    public string? MenuCreate { get; set; }

    public string? MenuEdit { get; set; }

    public string? MenuDelete { get; set; }

    public string? MenuRead { get; set; }

    public string? MenuPrint { get; set; }

    public string UnitId { get; set; } = null!;
}
