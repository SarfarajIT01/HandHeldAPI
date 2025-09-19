using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCityevent
{
    public string? CityCode { get; set; }

    public string? EventType { get; set; }

    public string? EventCode { get; set; }

    public string? Subject { get; set; }

    public string? Venue { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? Day1 { get; set; }

    public string? Day2 { get; set; }

    public string? Day3 { get; set; }

    public string? Day4 { get; set; }

    public string? Day5 { get; set; }

    public string? Day6 { get; set; }

    public string? Day7 { get; set; }

    public string? Picture { get; set; }

    public string? Dflag { get; set; }

    public string? AboutMe { get; set; }

    public string? Status { get; set; }
}
