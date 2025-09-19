using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlGuestComm
{
    public string? OutletId { get; set; }

    public string? GuestId { get; set; }

    public string? CommType { get; set; }

    public string? CommId { get; set; }
}
