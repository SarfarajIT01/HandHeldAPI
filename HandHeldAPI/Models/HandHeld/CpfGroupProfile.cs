using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CpfGroupProfile
{
    public short? GrCode { get; set; }

    public string? ModuleId { get; set; }

    public string? MenuValue { get; set; }

    public string? MenuText { get; set; }

    public string? MenuCreate { get; set; }

    public string? MenuEdit { get; set; }

    public string? MenuDelete { get; set; }

    public string? MenuRead { get; set; }

    public string? StartFrom { get; set; }
}
