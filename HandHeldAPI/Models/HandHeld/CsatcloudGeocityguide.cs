using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGeocityguide
{
    public string Flag { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public byte[]? Icon { get; set; }

    public string? NameFlag { get; set; }
}
