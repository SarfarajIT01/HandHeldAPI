using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCompDisc
{
    public string? CompCode { get; set; }

    public string? Flag { get; set; }

    public string? TrnType { get; set; }

    public float? Discount { get; set; }

    public string? Acflag { get; set; }

    public double? Dbrent { get; set; }

    public double? Sgrent { get; set; }

    public double? Exrent { get; set; }

    public double? Mnrent { get; set; }

    public string? ChargeType { get; set; }

    public double? Ifrent { get; set; }

    public string? ChargeTypeMeal { get; set; }

    public double? Apfit { get; set; }

    public double? Apgit { get; set; }

    public double? Mapfit { get; set; }

    public double? Mapgit { get; set; }

    public double? Cpfit { get; set; }

    public double? Cpgit { get; set; }

    public double? Epfit { get; set; }

    public double? Epgit { get; set; }

    public string? MealPlan { get; set; }

    public string? TrnHead { get; set; }

    public double? DailyDiscAmt { get; set; }

    public string? DiscIn { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
