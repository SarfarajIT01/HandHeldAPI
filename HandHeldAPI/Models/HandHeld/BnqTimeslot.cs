using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqTimeslot
{
    public int Id { get; set; }

    public string? TitleCode { get; set; }

    public string? TitleName { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? OutletCode { get; set; }
}
