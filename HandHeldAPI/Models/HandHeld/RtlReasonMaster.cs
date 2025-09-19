using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlReasonMaster
{
    public string OutletId { get; set; } = null!;

    public string? Code { get; set; }

    public string? ShortDesc { get; set; }

    public string? Description { get; set; }

    public string? Reason { get; set; }

    public string? Active { get; set; }
}
