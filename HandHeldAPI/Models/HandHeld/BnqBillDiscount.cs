using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillDiscount
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public double? VenueDis { get; set; }

    public double? PaxDis { get; set; }

    public double? AccDis { get; set; }

    public double? OthDis { get; set; }

    public double? OpenDis { get; set; }

    public double? VenueAmt { get; set; }

    public double? PaxAmt { get; set; }

    public double? AccAmt { get; set; }

    public double? OthAmt { get; set; }

    public double? OpenAmt { get; set; }

    public string? OutletCode { get; set; }
}
