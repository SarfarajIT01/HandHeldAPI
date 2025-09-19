using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudFeedbackGroup
{
    public string FbGrpCode { get; set; } = null!;

    public string? FbGrpDesc { get; set; }

    public string? Status { get; set; }

    public string ModCode { get; set; } = null!;
}
