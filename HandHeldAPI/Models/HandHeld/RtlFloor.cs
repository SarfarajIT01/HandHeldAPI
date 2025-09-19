using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlFloor
{
    public string FloorId { get; set; } = null!;

    public string? FloorName { get; set; }

    public string? Status { get; set; }
}
