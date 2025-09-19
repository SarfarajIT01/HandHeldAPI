using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlDiscDow
{
    public string? OutletId { get; set; }

    public string? PosCode { get; set; }

    public string? DiscCode { get; set; }

    public short? DiscDow { get; set; }
}
