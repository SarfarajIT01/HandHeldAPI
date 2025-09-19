using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingAmount
{
    public int Id { get; set; }

    public string? ReservNo { get; set; }

    public double? SubTotal { get; set; }

    public double? Stax { get; set; }

    public double? OtherTax { get; set; }

    public double? SerTax { get; set; }

    public double? NetAmt { get; set; }

    public double? TotalDisc { get; set; }

    public string? OutletCode { get; set; }
}
