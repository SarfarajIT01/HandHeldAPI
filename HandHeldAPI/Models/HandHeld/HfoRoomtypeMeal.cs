using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomtypeMeal
{
    public string? Rmtype { get; set; }

    public string? MealPlan { get; set; }

    public float? MealValue { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
