using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDealsDow
{
    public string? PosCode { get; set; }

    public string? DiscCode { get; set; }

    public short? DiscDow { get; set; }

    public string? OutletId { get; set; }
}
