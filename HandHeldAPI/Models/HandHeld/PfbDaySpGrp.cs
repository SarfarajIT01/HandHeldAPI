using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDaySpGrp
{
    public int ChefId { get; set; }

    public string? EffDate { get; set; }

    public string? Grp { get; set; }

    public string? Comments { get; set; }

    public string? OutletId { get; set; }
}
