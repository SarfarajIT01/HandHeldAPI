using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTimeSlotSetup
{
    public int Id { get; set; }

    public bool? ActTimeSlot { get; set; }

    public string? Ci1Time1 { get; set; }

    public string? Ci1Time2 { get; set; }

    public double? Ci1Disc { get; set; }

    public string? Ci2Time1 { get; set; }

    public string? Ci2Time2 { get; set; }

    public double? Ci2Disc { get; set; }

    public string? Ci3Time1 { get; set; }

    public string? Ci3Time2 { get; set; }

    public double? Ci3Disc { get; set; }

    public string? Co1Time1 { get; set; }

    public string? Co1Time2 { get; set; }

    public double? Co1Disc { get; set; }

    public string? Co2Time1 { get; set; }

    public string? Co2Time2 { get; set; }

    public double? Co2Disc { get; set; }

    public string? Co3Time1 { get; set; }

    public string? Co3Time2 { get; set; }

    public double? Co3Disc { get; set; }

    public string? EpTime1 { get; set; }

    public string? EpTime2 { get; set; }

    public string? CpTime1 { get; set; }

    public string? CpTime2 { get; set; }

    public string? MapTime1 { get; set; }

    public string? MapTime2 { get; set; }

    public string? ApTime1 { get; set; }

    public string? ApTime2 { get; set; }

    public bool? ActMealPlanTimeSlot { get; set; }

    public double? EpAmt { get; set; }

    public double? CpAmt { get; set; }

    public double? MapAmt { get; set; }

    public double? ApAmt { get; set; }

    public string? Ci4Time1 { get; set; }

    public string? Ci4Time2 { get; set; }

    public double? Ci4Disc { get; set; }

    public string? Co4Time1 { get; set; }

    public string? Co4Time2 { get; set; }

    public double? Co4Disc { get; set; }

    public string? SloteType { get; set; }

    public string? OutletId { get; set; }
}
