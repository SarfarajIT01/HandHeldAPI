using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestBillInst
{
    public string? GuestId { get; set; }

    public string? Grno { get; set; }

    public string? BillIns { get; set; }

    public string? BillType { get; set; }

    public string? TrnType { get; set; }

    public string? BillNo { get; set; }

    public bool? BillBtc { get; set; }

    public bool? BillAgent { get; set; }

    public bool? BillGroup { get; set; }

    public bool? BillSelf { get; set; }

    public string? BillPaymentMode { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public short? VisitNo { get; set; }

    public string? HfoGacid { get; set; }
}
