using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqPaymentReceipt
{
    public string? ReceiptNo { get; set; }

    public DateTime? BillDate { get; set; }

    public string? Guestid { get; set; }

    public double? ReceiptAmt { get; set; }

    public string? BnqSmode { get; set; }

    public string? SettCurrency { get; set; }

    public string? BillNo { get; set; }

    public string? Narration { get; set; }

    public string? PayModeNo { get; set; }

    public string? PayModeName { get; set; }

    public DateTime? PayModeDate { get; set; }

    public string? Rocno { get; set; }

    public string? RecFlag { get; set; }

    public string? RecStatus { get; set; }

    public string? RecReason { get; set; }

    public string? RecRefFlag { get; set; }

    public string? OrgBillNo { get; set; }

    public string? FinPost { get; set; }

    public string? Ecno { get; set; }

    public string? Gvflag { get; set; }

    public string? ReferenceNo { get; set; }

    public string? GuestFlag { get; set; }

    public string? DguestName { get; set; }

    public string? DguestAdd1 { get; set; }

    public string? DguestAdd2 { get; set; }

    public string? Uid { get; set; }

    public string? BranchName { get; set; }
}
