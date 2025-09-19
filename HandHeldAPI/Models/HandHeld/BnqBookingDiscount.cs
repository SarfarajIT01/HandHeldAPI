using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingDiscount
{
    public int Id { get; set; }

    public string? ResNo { get; set; }

    public double? VenueDis { get; set; }

    public double? PaxDis { get; set; }

    public double? AccDis { get; set; }

    public double? OthDis { get; set; }

    public double? OpenDis { get; set; }

    public string? OutletCode { get; set; }
}
