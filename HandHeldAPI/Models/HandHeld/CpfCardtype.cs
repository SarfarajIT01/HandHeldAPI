using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CpfCardtype
{
    public string? Cardtype { get; set; }

    public string? Cardname { get; set; }

    public string? Rangefrom { get; set; }

    public string? Rangeto { get; set; }

    public string? Validity { get; set; }

    public string? Rd { get; set; }

    public double? Minval { get; set; }

    public double? Minref { get; set; }
}
