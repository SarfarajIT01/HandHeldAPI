using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoMealplanBreakup
{
    public int Id { get; set; }

    public string? MealPlan { get; set; }

    public string? RoomType { get; set; }

    public int? Pax { get; set; }

    public string? TrnCode { get; set; }

    public string? TrnSubCode { get; set; }

    public decimal? TrnAmount { get; set; }

    public int? OrderNo { get; set; }

    public double? MealTax { get; set; }

    public string? MealTaxType { get; set; }

    public string? MealTaxstru { get; set; }

    public string? MealFlag { get; set; }

    public double? ExtraRate { get; set; }

    public double? MinerRate { get; set; }

    public double? InfantRate { get; set; }

    public string? MealPlanType { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
