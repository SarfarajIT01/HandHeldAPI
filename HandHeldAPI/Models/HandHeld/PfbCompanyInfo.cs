using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCompanyInfo
{
    public string CompCode { get; set; } = null!;

    public string? CompName { get; set; }

    public string? Acflag { get; set; }

    public float? PerDiscount { get; set; }

    public float? PerComission { get; set; }

    public float? PerTds { get; set; }

    public string? Pmeal { get; set; }

    public string? CrBilling { get; set; }

    public string? CompAc { get; set; }

    public string? ParCode { get; set; }

    public string? AgentName { get; set; }

    public string? Status { get; set; }

    public string? AllowMail { get; set; }

    public string? RoomSharing { get; set; }

    public float? RoomSharingT { get; set; }

    public string? ResRemark { get; set; }

    public string? BillingRemark { get; set; }

    public string? CompStatus { get; set; }

    public string? Picture { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }

    public string? OutletId { get; set; }
}
