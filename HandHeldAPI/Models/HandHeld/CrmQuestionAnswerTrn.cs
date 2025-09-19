using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmQuestionAnswerTrn
{
    public string? CcardNo { get; set; }

    public string? GuestCode { get; set; }

    public string? CrmType { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public string? Remark { get; set; }
}
