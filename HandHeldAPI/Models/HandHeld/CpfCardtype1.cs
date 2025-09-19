using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CpfCardtype1
{
    public string Cardtype { get; set; } = null!;

    public string? OutletId { get; set; }

    public string? Active { get; set; }
}
