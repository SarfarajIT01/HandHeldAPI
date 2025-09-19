using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlGuestRating
{
    public string? OutletId { get; set; }

    public string? GuestId { get; set; }

    public string? CcPara { get; set; }

    public string? CcRat { get; set; }
}
