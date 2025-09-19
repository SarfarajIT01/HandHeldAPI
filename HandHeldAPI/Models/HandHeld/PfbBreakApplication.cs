using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbBreakApplication
{
    public string? CardNo { get; set; }

    public string? SessionId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Uid { get; set; }

    public string? Reason { get; set; }

    public DateTime? TrnDat { get; set; }
}
