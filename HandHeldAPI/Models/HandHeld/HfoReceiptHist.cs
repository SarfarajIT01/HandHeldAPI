using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoReceiptHist
{
    public string? RoomNo { get; set; }

    public string? Guestid { get; set; }

    public short? VisitNo { get; set; }

    public string? ReceiptNo { get; set; }

    public DateTime? BillDate { get; set; }

    public double? ReceiptAmt { get; set; }

    public string? SettlementMode { get; set; }

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

    public short? HistNo { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModTime { get; set; }

    public string? UserId { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? HfoGacid { get; set; }
}
