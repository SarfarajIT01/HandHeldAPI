using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestPlan
{
    public string? GuestId { get; set; }

    public string? RoomNo { get; set; }

    public string? Grno { get; set; }

    public string? MealPlan { get; set; }

    public string? TrnCode { get; set; }

    public string? TrnSubCode { get; set; }

    public decimal? TrnAmount { get; set; }

    public string? TaxStru { get; set; }

    public string? MealFlag { get; set; }

    public decimal? TrnTotal { get; set; }

    public decimal? ExtraRate { get; set; }

    public decimal? MinerRate { get; set; }

    public decimal? InfantRate { get; set; }

    public string? GmembId { get; set; }

    public DateTime? PlanDate { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public short? VisitNo { get; set; }
}
