using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingBreakDetail
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? ResNo { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? BillTime { get; set; }

    public string? InchargeCode { get; set; }

    public string? VenueCode { get; set; }

    public bool? FlagAllSubVenues { get; set; }

    public double? VenueRate { get; set; }

    public string? FunctionCode { get; set; }

    public DateTime? FunctionDate { get; set; }

    public DateTime? FunctionFromTime { get; set; }

    public DateTime? FunctionToTime { get; set; }

    public int? NoOfPax { get; set; }

    public double? PaxCharge { get; set; }

    public string? SettlementCode { get; set; }

    public string? Remark { get; set; }

    public bool? IsGuest { get; set; }

    public string? GuestCode { get; set; }

    public double? DiscPer { get; set; }

    public double? BillAmt { get; set; }

    public double? DiscAmt { get; set; }

    public string? MenuCode { get; set; }

    public string? SelectionCode { get; set; }

    public DateTime? ToDate { get; set; }

    public string? TypeOfMenu { get; set; }

    public string? TaxStructure { get; set; }

    public double? PaymentReceipt { get; set; }

    public double? AccAmt { get; set; }

    public double? ServiceAmt { get; set; }

    public double? OpenItemAmt { get; set; }

    public string? TsonBillAmt { get; set; }

    public string? SettCode { get; set; }

    public DateTime? SettDate { get; set; }

    public double? CreditedAmount { get; set; }

    public string? BillStatus { get; set; }

    public string? CancelReason { get; set; }

    public string? SettCode2 { get; set; }

    public string? SettMod2 { get; set; }

    public double? SettAmt2 { get; set; }

    public string? SettVouchrNo2 { get; set; }

    public string? SettMod1 { get; set; }

    public double? SettAmt1 { get; set; }

    public string? SettVouchrNo1 { get; set; }

    public string? TipsSettCode { get; set; }

    public string? TipsSettMode { get; set; }

    public double? TipsSettAmt { get; set; }

    public string? TipsSettVouchrNo { get; set; }

    public string? GuestName { get; set; }

    public string? RoomNo { get; set; }

    public double? BillRound { get; set; }

    public string? BillingOn { get; set; }

    public string? Company { get; set; }

    public string? DirectGuest { get; set; }

    public string? CompanyName { get; set; }

    public string? BillTm { get; set; }

    public DateTime? FunctionFtm { get; set; }

    public DateTime? FunctionTtm { get; set; }

    public DateTime? BreakDate { get; set; }

    public bool? BreakFlag { get; set; }
}
