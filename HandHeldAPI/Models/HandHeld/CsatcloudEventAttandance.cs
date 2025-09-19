using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudEventAttandance
{
    public string EventCode { get; set; } = null!;

    public string? Memno { get; set; }

    public string? EventAlrttime { get; set; }

    public string? EventVenue1 { get; set; }

    public string? AboutEvent1 { get; set; }

    public string UnitCode { get; set; } = null!;
}
