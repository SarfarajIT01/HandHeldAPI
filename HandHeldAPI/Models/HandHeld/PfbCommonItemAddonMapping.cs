using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCommonItemAddonMapping
{
    public int Idd { get; set; }

    public string? ItemCode { get; set; }

    public short? GroupCode { get; set; }
}
