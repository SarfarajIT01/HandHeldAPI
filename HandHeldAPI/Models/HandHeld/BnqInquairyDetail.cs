using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqInquairyDetail
{
    public int Id { get; set; }

    public string? InqNo { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? FunctionCode { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? ExpPax { get; set; }

    public int? GuaPax { get; set; }

    public string? TypeOfFunc { get; set; }

    public DateTime? EndDate { get; set; }

    public double? PaxCharge { get; set; }

    public DateTime? StTm { get; set; }

    public DateTime? EndTm { get; set; }

    public string? VenueCode { get; set; }

    public string? MenuType { get; set; }

    public string? OutletCode { get; set; }
}
