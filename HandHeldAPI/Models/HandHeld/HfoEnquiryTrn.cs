using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoEnquiryTrn
{
    public string? EnqNo { get; set; }

    public DateTime? EnqDate { get; set; }

    public string? OrgType { get; set; }

    public double? ItYrIss { get; set; }

    public string? EnqName { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public string? City { get; set; }

    public string? Phone1 { get; set; }

    public string? ResType { get; set; }

    public string? MobNo { get; set; }

    public double? Amount { get; set; }

    public string? RefNo { get; set; }

    public string? Requirement { get; set; }

    public DateTime? ValidDate { get; set; }

    public string? EnqStatus { get; set; }

    public string? OrgName { get; set; }

    public DateTime? ResEnqFromdate { get; set; }

    public DateTime? ResEnqToDate { get; set; }

    public string? ResNo { get; set; }

    public string? EnqSource { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
