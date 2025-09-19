using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmCommentParameterTrn
{
    public string CcardNo { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Parameter { get; set; }

    public string? Remarks { get; set; }

    public string? GuestCode { get; set; }

    public string? CrmType { get; set; }
}
