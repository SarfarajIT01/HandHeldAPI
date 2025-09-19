using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlOutletMap
{
    public string OutletId { get; set; } = null!;

    public string? OpType { get; set; }

    public string? OpCode { get; set; }

    public string? Status { get; set; }
}
