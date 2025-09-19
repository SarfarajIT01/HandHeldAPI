using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqVenueFeatureMst
{
    public string VenueFeatureId { get; set; } = null!;

    public string? VenueFeatureDesc { get; set; }

    public string? VenueFeatureStatus { get; set; }
}
