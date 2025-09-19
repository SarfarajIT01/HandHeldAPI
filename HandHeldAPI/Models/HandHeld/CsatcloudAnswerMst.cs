using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudAnswerMst
{
    public string FaqCode { get; set; } = null!;

    public string FaCode { get; set; } = null!;

    public string? FaDescription { get; set; }

    public string? Status { get; set; }

    public string ModCode { get; set; } = null!;
}
