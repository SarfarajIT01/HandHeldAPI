using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingMst
{
    public string ResNo { get; set; } = null!;

    public string? InqNo { get; set; }

    public DateTime? ResDate { get; set; }

    public DateTime? ResTime { get; set; }

    public string? InchargeCode { get; set; }

    public string? VenueCode { get; set; }

    public bool? FlagAllSubVenues { get; set; }

    public int? VenueRate { get; set; }

    public string? FunctionCode { get; set; }

    public DateTime? FunctionDate { get; set; }

    public DateTime? FunctionFromTime { get; set; }

    public DateTime? FunctionToTime { get; set; }

    public int? ExpPax { get; set; }

    public int? GuaPax { get; set; }

    public double? PaxCharge { get; set; }

    public string? SettlementCode { get; set; }

    public string? Remark { get; set; }

    public bool? IsGuest { get; set; }

    public string? GuestCode { get; set; }

    public string? MenuCode { get; set; }

    public string? SelectionCode { get; set; }

    public DateTime? ToDate { get; set; }

    public string? TypeOfMenu { get; set; }

    public string? Status { get; set; }

    public string? TaxCode { get; set; }

    public double? ResTotalAmt { get; set; }

    public string? ResBillInst { get; set; }

    public string? Company { get; set; }

    public string? DirectGuest { get; set; }

    public string? GuestName { get; set; }

    public string? CompanyName { get; set; }

    public string? ResTm { get; set; }

    public string? FunctionFtm { get; set; }

    public string? FunctionTtm { get; set; }

    public bool? Audited { get; set; }

    public DateTime? AuditDate { get; set; }

    public string? AuditOperator { get; set; }

    public string? OutletCode { get; set; }
}
