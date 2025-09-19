using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudSupplier
{
    public string CompCode { get; set; } = null!;

    public string CompName { get; set; } = null!;

    public string Acflag { get; set; } = null!;

    public float? PerDiscount { get; set; }

    public float? PerComission { get; set; }

    public float? PerTds { get; set; }

    public string? Pmeal { get; set; }

    public string? CrBilling { get; set; }

    public string? CompAc { get; set; }

    public string? ParCode { get; set; }

    public string? Status { get; set; }

    public string? AgentName { get; set; }

    public string? CompAdd1 { get; set; }

    public string? CompAdd2 { get; set; }

    public string? CompCity { get; set; }

    public string? CompPin { get; set; }

    public string? Remark { get; set; }

    public string? Panno { get; set; }

    public string? AltPerson { get; set; }

    public string? AccLedcode { get; set; }

    public string? OldsysCode { get; set; }

    public string? Emailid { get; set; }

    public string? Phone { get; set; }

    public string? Autocode { get; set; }
}
