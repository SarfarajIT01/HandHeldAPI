using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResMstTempReg
{
    public string? ResNo { get; set; }

    public string? GuestCode { get; set; }

    public DateTime? ResDate { get; set; }

    public string? ResType { get; set; }

    public string? ResMode { get; set; }

    public string? GuestTitle { get; set; }

    public string? GuestClass { get; set; }

    public string? BookedBy { get; set; }

    public string? AgentName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public short? Adult { get; set; }

    public short? Minor { get; set; }

    public short? Infant { get; set; }

    public string? CompName { get; set; }

    public string? CompUnit { get; set; }

    public string? Remark { get; set; }

    public bool? PenConf { get; set; }

    public string? ReceiptNo { get; set; }

    public string? MealPlan { get; set; }

    public string? PkgPlan { get; set; }

    public string? FoodPref { get; set; }

    public string? BillIns { get; set; }

    public string? BillToComp { get; set; }

    public string? ResStatus { get; set; }

    public string? RateType { get; set; }

    public string? BbyPhone { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
