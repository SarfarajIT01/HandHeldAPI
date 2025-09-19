using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbGuestDisc
{
    public string? OutletId { get; set; }

    public string? GuestCode { get; set; }

    public string? GrpCode { get; set; }

    public double? Disc { get; set; }
}
