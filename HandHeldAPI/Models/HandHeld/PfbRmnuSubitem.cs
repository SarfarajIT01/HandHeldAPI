using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbRmnuSubitem
{
    public string RmnuSubCod { get; set; } = null!;

    public string? RmnuCod { get; set; }

    public string? RmnuSubStd { get; set; }

    public string? RmnuSubPict { get; set; }

    public double? RmnuSubBcolor { get; set; }
}
