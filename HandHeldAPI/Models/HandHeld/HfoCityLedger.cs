using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCityLedger
{
    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? CityLedNo { get; set; }

    public double? CityLedAmt { get; set; }

    public string? HotelCode { get; set; }
}
