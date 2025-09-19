using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlSettlementOutlet
{
    public string OutletId { get; set; } = null!;

    public string? SettlementCode { get; set; }

    public string? Description { get; set; }
}
