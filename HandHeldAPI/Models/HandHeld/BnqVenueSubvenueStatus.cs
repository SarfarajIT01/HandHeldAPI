using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqVenueSubvenueStatus
{
    public string? VenueCode { get; set; }

    public string? SubVenueCode { get; set; }

    public string? FromDateTime { get; set; }

    public string? ToDateTime { get; set; }
}
