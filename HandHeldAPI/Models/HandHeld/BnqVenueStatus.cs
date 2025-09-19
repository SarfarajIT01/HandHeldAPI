using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqVenueStatus
{
    public string? VenueCode { get; set; }

    public bool? FlagAllSubVenues { get; set; }

    public string? FromDateTime { get; set; }

    public string? ToDateTime { get; set; }

    public string? Reason { get; set; }
}
