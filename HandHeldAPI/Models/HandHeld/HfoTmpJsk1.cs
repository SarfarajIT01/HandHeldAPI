using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTmpJsk1
{
    public string? BillNo { get; set; }

    public string? GuestCode { get; set; }

    public short? VisitNo { get; set; }

    public double? BillAmt { get; set; }

    public double? RecAmt { get; set; }

    public double? StaxAmt { get; set; }

    public double? LtaxAmt { get; set; }

    public double? SurTaxAmt { get; set; }

    public double? Otax1Amt { get; set; }

    public double? Otax2Amt { get; set; }

    public DateTime? Date1 { get; set; }

    public string? Jsk3 { get; set; }

    public string? Jsk4 { get; set; }

    public string? Jsk5 { get; set; }

    public string? Jsk6 { get; set; }

    public string? Jsk7 { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
