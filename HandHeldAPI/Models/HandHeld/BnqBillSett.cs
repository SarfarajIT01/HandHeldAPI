using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillSett
{
    public int Id { get; set; }

    public string? BnqPos { get; set; }

    public string? BnqRefNo { get; set; }

    public DateTime? BnqSettDate { get; set; }

    public string? BnqBillNo { get; set; }

    public DateTime? BnqDate { get; set; }

    public double? BnqAmount { get; set; }

    public string? BnqTime { get; set; }

    public string? BnqScode { get; set; }

    public string? BnqCcno { get; set; }

    public string? BnqCcdate { get; set; }

    public string? BnqCcbank { get; set; }

    public string? BnqCcbranch { get; set; }

    public string? BnqCashier { get; set; }

    public double? BnqTipAmt { get; set; }

    public string? BnqRemark { get; set; }

    public string? BnqGflag { get; set; }

    public string? BnqRflag { get; set; }

    public string? BnqRecStatus { get; set; }

    public string? BnqGuestId { get; set; }

    public string? BnqBookingNo { get; set; }

    public double? BnqSettAdvAmt { get; set; }

    public string? BnqRecDate { get; set; }

    public string? DirectGuest { get; set; }

    public string? BnqSmode { get; set; }

    public string? BnqIsTipAmt { get; set; }

    public bool? Audited { get; set; }

    public DateTime? AuditDate { get; set; }

    public string? AuditOperator { get; set; }

    public string? OutletCode { get; set; }
}
