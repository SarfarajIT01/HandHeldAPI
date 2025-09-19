using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaxtemplate
{
    public string TempCode { get; set; } = null!;

    public DateTime EffDate { get; set; }

    public string? TempName { get; set; }

    public string? CommuTaxCode { get; set; }

    public string? Status { get; set; }
}
