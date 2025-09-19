using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqEnquaryFollowUp
{
    public string? InqNo { get; set; }

    public DateTime? FollowupDate { get; set; }

    public DateTime? NextFollowupDate { get; set; }

    public string? Incharge { get; set; }

    public string? Commant { get; set; }

    public string? Commtype { get; set; }

    public DateTime? NextFollowupTime { get; set; }

    public string? Nexttodo { get; set; }

    public string? Follcommtype { get; set; }

    public string? Flag { get; set; }

    public string? OutletCode { get; set; }
}
