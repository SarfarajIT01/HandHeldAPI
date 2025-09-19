using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoMealplanMst
{
    public int Id { get; set; }

    public string? MealPlan { get; set; }

    public string? RoomType { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public short? Pax { get; set; }

    public string? MealFlag { get; set; }

    public string? MealPlanType { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
