using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmCardMst
{
    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? SNo { get; set; }

    public string? ENo { get; set; }

    public short? Disc { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ValidUptoDate { get; set; }

    public string Loyality { get; set; } = null!;

    public string? Status { get; set; }

    public double? Famount { get; set; }

    public double? Tamount { get; set; }

    public double? Points { get; set; }

    public double? BasePoint { get; set; }

    public double? Pointper { get; set; }

    public double? MinRedPoints { get; set; }

    public short? SkipDigit { get; set; }

    public string? OutletId { get; set; }
}
