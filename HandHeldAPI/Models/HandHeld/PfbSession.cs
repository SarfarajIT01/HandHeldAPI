using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbSession
{
    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public string? SessionId { get; set; }

    public string? SessionName { get; set; }

    public string? SessionSrNo { get; set; }

    public string? SessionType { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Status { get; set; }
}
