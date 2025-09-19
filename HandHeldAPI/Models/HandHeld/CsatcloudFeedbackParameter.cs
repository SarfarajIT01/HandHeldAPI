using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudFeedbackParameter
{
    public string FbpGrpCode { get; set; } = null!;

    public string ModuleCode { get; set; } = null!;

    public string? FbpParaDesc { get; set; }

    public string? FInput { get; set; }

    public string? FbpRemarks { get; set; }

    public string? Status { get; set; }

    public string FbpParaCode { get; set; } = null!;
}
