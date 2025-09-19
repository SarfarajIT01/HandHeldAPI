using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestBill
{
    public string? GuestId { get; set; }

    public DateTime? ArrDate { get; set; }

    public string? BillTo { get; set; }

    public string? BillingIns { get; set; }

    public string? ModeofPayment { get; set; }

    public string? PayCurrency { get; set; }

    public double? CreditLimit { get; set; }

    public string? Agent { get; set; }

    public string? ModeofTrans { get; set; }

    public string? Vno { get; set; }

    public float? Comission { get; set; }

    public double? AdvAmt { get; set; }

    public string? ReceiptNo { get; set; }

    public string? Grno { get; set; }

    public float? Tds { get; set; }

    public float? Tac { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
