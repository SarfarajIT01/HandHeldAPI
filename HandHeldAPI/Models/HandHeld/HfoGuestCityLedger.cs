using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoGuestCityLedger
{
    public DateTime? LdgDate { get; set; }

    public string? LdgType { get; set; }

    public string? RecNo { get; set; }

    public string? GuestId { get; set; }

    public string? Grno { get; set; }

    public string? SettMode { get; set; }

    public double? SettAmount { get; set; }

    public bool? CommAmount { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
