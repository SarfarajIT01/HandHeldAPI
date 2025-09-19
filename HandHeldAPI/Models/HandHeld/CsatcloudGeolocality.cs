using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGeolocality
{
    public string ArLocPinFlag { get; set; } = null!;

    public string? Location { get; set; }

    public string? Area { get; set; }

    public string? Pincode { get; set; }

    public string ArLocPinCode { get; set; } = null!;

    public string? CityCode { get; set; }
}
