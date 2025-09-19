using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HmsCompMealplanDisc
{
    public string? CompCode { get; set; }

    public string? Flag { get; set; }

    public string? TrnType { get; set; }

    public string? ChargeTypeMeal { get; set; }

    public string? Fitsgl { get; set; }

    public string? Fitdbl { get; set; }

    public string? Fitextra { get; set; }

    public string? Gitsgl { get; set; }

    public string? Gitdbl { get; set; }

    public string? Gitextra { get; set; }

    public string? MealPlan { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
