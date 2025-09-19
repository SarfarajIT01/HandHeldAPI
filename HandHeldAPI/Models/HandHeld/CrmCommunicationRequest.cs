using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmCommunicationRequest
{
    public DateTime? CommDate { get; set; }

    public DateTime? CommTime { get; set; }

    public string? Mode { get; set; }

    public string? Subject { get; set; }

    public string? CrNote { get; set; }

    public string? FlagGc { get; set; }

    public string? FollowActive { get; set; }

    public string? GuestCode { get; set; }

    public string? CrmType { get; set; }

    public string? CrCode { get; set; }
}
