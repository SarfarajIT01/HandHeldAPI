using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqSubVenueMst
{
    public string? SubVenueCode { get; set; }

    public string? VenueCode { get; set; }

    public string? SubVenueDesc { get; set; }

    public int? MinPax { get; set; }

    public int? SeatPax { get; set; }

    public int? FloatingPax { get; set; }

    public string? Status { get; set; }

    public double? SubVenueCharge { get; set; }

    public string? OutletCode { get; set; }
}
