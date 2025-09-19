using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTmpBillReceipt
{
    public string? ReceiptNo { get; set; }

    public DateTime? BillDate { get; set; }

    public double? ReceiptAmt { get; set; }

    public string? SettlementMode { get; set; }

    public string? BillNo { get; set; }

    public string? Narration { get; set; }

    public double? SubAmt { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
