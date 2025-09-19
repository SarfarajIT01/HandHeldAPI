using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTravelagent
{
    public string AgentCode { get; set; } = null!;

    public string? AgentName { get; set; }

    public string? Acflag { get; set; }

    public float? PerDiscount { get; set; }

    public float? PerTac { get; set; }

    public float? PerTds { get; set; }

    public string? Pmeal { get; set; }

    public string? CrBilling { get; set; }

    public string? CompAc { get; set; }

    public string? ParCode { get; set; }

    public string? Status { get; set; }

    public string? AgentName1 { get; set; }

    public string? AgentAdd1 { get; set; }

    public string? AgentAdd2 { get; set; }

    public string? AgentCity { get; set; }

    public string? AgentPin { get; set; }

    public string? Remark { get; set; }

    public string? Panno { get; set; }

    public string? AltPerson { get; set; }

    public string? AccLedcode { get; set; }

    public string? OldsysCode { get; set; }

    public string? Phone { get; set; }

    public string? Autocode { get; set; }

    public string? Emailid { get; set; }
}
