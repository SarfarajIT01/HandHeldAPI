using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillMst
{
    public string? BillNo { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? Mode { get; set; }

    public DateTime? CoutDate { get; set; }

    public string? GuestCode { get; set; }

    public string? Grno { get; set; }

    public string? BillStatus { get; set; }

    public string? GuestStatus { get; set; }

    public string? PreviousBillNo { get; set; }

    public string? NextBillNo { get; set; }

    public double? BillAmt { get; set; }

    public double? RecAmt { get; set; }

    public double? StaxAmt { get; set; }

    public double? LtaxAmt { get; set; }

    public double? SurTaxAmt { get; set; }

    public double? Otax1Amt { get; set; }

    public double? Otax2Amt { get; set; }

    public float? RoffAmt { get; set; }

    public double? OthBillAmt { get; set; }

    public string? Creason { get; set; }

    public DateTime? OpenDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public short? PrintTimes { get; set; }

    public string? MemberNo { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public short? Visitno { get; set; }

    public string? HfoGacid { get; set; }
}
