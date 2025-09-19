using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqInquairyMst
{
    public int Id { get; set; }

    public string? InqNo { get; set; }

    public string? VenueCode { get; set; }

    public DateTime? InqDate { get; set; }

    public DateTime? InqTime { get; set; }

    public string? Remark { get; set; }

    public bool? FlagVisNew { get; set; }

    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public bool? Status { get; set; }

    public int? VenueRate { get; set; }

    public bool? FlagAllSubVenues { get; set; }

    public string? InqStatus { get; set; }

    public string? InqTm { get; set; }

    public string? CompCode { get; set; }

    public string? BookSource { get; set; }

    public string? OutletCode { get; set; }
}
