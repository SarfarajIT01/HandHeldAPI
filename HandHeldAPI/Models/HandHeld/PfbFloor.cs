using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbFloor
{
    public string FloorId { get; set; } = null!;
    public string? FloorName { get; set; }
    public string? Status { get; set; }
    public string? FloorDesc { get; set; } // Add this property
}

