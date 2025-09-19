using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTmpBill
{
    public string? GuestCode { get; set; }

    public double? Lodg { get; set; }

    public double? Reten { get; set; }

    public double? Laun { get; set; }

    public double? Food { get; set; }

    public short? VisitNo { get; set; }

    public string? GuestCode1 { get; set; }

    public DateTime? BillDate { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }
}
