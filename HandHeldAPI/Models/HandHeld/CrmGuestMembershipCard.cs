using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmGuestMembershipCard
{
    public string? GuestId { get; set; }

    public string? CardType { get; set; }

    public string? CardNo { get; set; }

    public string? CardAllow { get; set; }

    public double? CardDisc { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ValidUptoDate { get; set; }

    public string Loc { get; set; } = null!;
}
