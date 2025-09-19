using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDaySpItem
{
    public string ItemCode { get; set; } = null!;

    public DateTime? EffDate { get; set; }

    public string? Grp { get; set; }

    public string? Comments { get; set; }

    public string? OutletId { get; set; }
}
