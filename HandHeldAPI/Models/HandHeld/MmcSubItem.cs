using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcSubItem
{
    public string? ItemCode { get; set; }

    public string? SCode { get; set; }

    public string? SName { get; set; }

    public double? SRate { get; set; }
}
