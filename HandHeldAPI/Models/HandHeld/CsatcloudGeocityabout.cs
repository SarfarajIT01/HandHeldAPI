using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGeocityabout
{
    public string CityCode { get; set; } = null!;

    public string? AboutType { get; set; }

    public string? AboutMessage { get; set; }

    public string? Status { get; set; }
}
