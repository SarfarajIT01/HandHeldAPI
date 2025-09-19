using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbRmnuAddon
{
    public int Idd { get; set; }

    public string? RmnuCod { get; set; }

    public string? RmnuAddonCod { get; set; }

    public string? RmnuAddonStd { get; set; }

    public decimal? RmnuAddonRate { get; set; }

    public string? RmnuAddonPict { get; set; }

    public double? RmnuAddonBcolor { get; set; }

    public string? RmnuScod { get; set; }
}
