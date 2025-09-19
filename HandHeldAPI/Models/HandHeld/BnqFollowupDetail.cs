using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqFollowupDetail
{
    public string? InqNo { get; set; }

    public DateTime? FollowupDate { get; set; }

    public DateTime? NextFollowupDate { get; set; }

    public DateTime? NextFollowupTime { get; set; }

    public string? Remark { get; set; }
}
