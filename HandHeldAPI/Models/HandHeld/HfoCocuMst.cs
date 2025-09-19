using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCocuMst
{
    public string? CocuCode { get; set; }

    public string? CocuFlag { get; set; }

    public double? CocuFor { get; set; }

    public double? CocuInd { get; set; }

    public string? CocuDesc { get; set; }

    public short? CocuDelF { get; set; }

    public string? CocuOflg { get; set; }

    public double? RmMealcp { get; set; }

    public double? RmMealmap { get; set; }

    public double? RmMealep { get; set; }

    public double? RmMealap { get; set; }

    public double? RmMealoth { get; set; }

    public string? CocuRem { get; set; }

    public DateTime? T1Date { get; set; }

    public DateTime? T2Date { get; set; }

    public string? GlCode { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
