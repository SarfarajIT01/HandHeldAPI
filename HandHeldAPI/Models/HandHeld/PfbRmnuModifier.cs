using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbRmnuModifier
{
    public int Idd { get; set; }

    public string? RmnuCod { get; set; }

    public string? RmnuMCod { get; set; }

    public string? RmnuMStd { get; set; }

    public string? RmnuMPict { get; set; }

    public double? RmnuMBcolor { get; set; }
}
