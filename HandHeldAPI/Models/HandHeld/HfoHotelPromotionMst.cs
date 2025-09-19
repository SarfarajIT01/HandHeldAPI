using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoHotelPromotionMst
{
    public string? HotelName { get; set; }

    public string? FoodFestivalName { get; set; }

    public DateTime? FrDate { get; set; }

    public DateTime? ToDate { get; set; }

    public double? TotalAmt { get; set; }

    public string? Remarks { get; set; }

    public string? Sponseship { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
