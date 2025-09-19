using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoGuestCitySettl
{
    public DateTime? SettDate { get; set; }

    public string? SettType { get; set; }

    public string? RecNo { get; set; }

    public string? GuestId { get; set; }

    public string? Grno { get; set; }

    public string? SettMode { get; set; }

    public double? SettAmount { get; set; }

    public double? CommAmount { get; set; }

    public string? CreditCno { get; set; }

    public string? AuthoNo { get; set; }

    public string? SettRemark { get; set; }

    public string? ModCode { get; set; }

    public double? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
