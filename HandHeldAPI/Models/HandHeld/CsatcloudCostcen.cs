using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCostcen
{
    public string CostCode { get; set; } = null!;

    public string? CostDesc { get; set; }

    public string? CostSdesc { get; set; }

    public string? CostStatus { get; set; }

    public string? CostRemark { get; set; }
}
