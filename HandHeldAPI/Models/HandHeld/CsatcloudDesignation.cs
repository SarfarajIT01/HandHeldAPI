using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudDesignation
{
    public string DesigCode { get; set; } = null!;

    public string? DesigName { get; set; }

    public string? Heir { get; set; }

    public string? Rem { get; set; }

    public decimal? MonthRate { get; set; }

    public decimal? DayRate { get; set; }

    public decimal? HourRate { get; set; }

    public string? Status { get; set; }

    public string? Desig { get; set; }
}
