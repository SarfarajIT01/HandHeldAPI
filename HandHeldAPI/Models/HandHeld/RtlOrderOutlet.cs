using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlOrderOutlet
{
    public string OutletId { get; set; } = null!;

    public string? Otypecode { get; set; }

    public string? Description { get; set; }
}
