using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcRatetypeMst
{
    public string? RateType { get; set; }

    public DateTime? EffDate { get; set; }

    public string? OnRate { get; set; }
}
