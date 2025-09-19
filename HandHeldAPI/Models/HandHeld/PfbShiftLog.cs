using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbShiftLog
{
    public DateTime? SDate { get; set; }

    public string? SName { get; set; }

    public string? STime { get; set; }

    public string? SUid { get; set; }

    public decimal? SAmt { get; set; }

    public string? SRemark { get; set; }

    public string? SFlag { get; set; }

    public string? SPos { get; set; }

    public string? SIpAdd { get; set; }

    public decimal? HAmt { get; set; }
}
