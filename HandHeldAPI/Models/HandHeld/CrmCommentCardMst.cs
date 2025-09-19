using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmCommentCardMst
{
    public string CcardNo { get; set; } = null!;

    public string? Location { get; set; }

    public DateTime? CDate { get; set; }

    public string? Positive { get; set; }

    public string? Negative { get; set; }

    public string? GuestCode { get; set; }

    public string? FlagGc { get; set; }

    public string? ModuleCode { get; set; }

    public string? Sugg { get; set; }
}
