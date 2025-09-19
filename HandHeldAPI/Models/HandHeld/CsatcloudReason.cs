using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudReason
{
    public string ReasonCode { get; set; } = null!;

    public string? ReasonDesc { get; set; }

    public string? ReasonSdesc { get; set; }

    public string? ReasonStatus { get; set; }

    public string? ReasonRemark { get; set; }

    public string? ReasonType { get; set; }
}
