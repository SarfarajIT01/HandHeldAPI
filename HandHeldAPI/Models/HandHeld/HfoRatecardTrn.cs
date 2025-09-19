using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRatecardTrn
{
    public int Id { get; set; }

    public string? RateCardCode { get; set; }

    public string? Rmtype { get; set; }

    public string? Flag { get; set; }

    public double? Discount { get; set; }

    public double? Dbrent { get; set; }

    public double? Sgrent { get; set; }

    public double? Exrent { get; set; }

    public double? Mnrent { get; set; }

    public double? Ifrent { get; set; }

    public string? ChargeType { get; set; }

    public string? ChargeTypeMeal { get; set; }

    public double? Apfit { get; set; }

    public double? Apgit { get; set; }

    public double? Mapfit { get; set; }

    public double? Mapgit { get; set; }

    public double? Cpfit { get; set; }

    public double? Cpgit { get; set; }

    public double? Epfit { get; set; }

    public double? Epgit { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public double? DiscMon { get; set; }

    public double? DiscTue { get; set; }

    public double? DiscWed { get; set; }

    public double? DiscThu { get; set; }

    public double? DiscFri { get; set; }

    public double? DiscSat { get; set; }

    public double? DiscSun { get; set; }
}
