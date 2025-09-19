using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudQuestionMst
{
    public string FbqCode { get; set; } = null!;

    public string? FbqDesc { get; set; }

    public string? Status { get; set; }

    public string? FbqRemarks { get; set; }

    public string ModCode { get; set; } = null!;
}
