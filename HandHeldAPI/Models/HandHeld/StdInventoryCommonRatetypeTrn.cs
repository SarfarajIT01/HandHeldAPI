using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryCommonRatetypeTrn
{
    public DateTime? EffDate { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemUom { get; set; }

    public double? ItemRate { get; set; }

    public double? OfferedRate { get; set; }

    public DateTime? EffDateTo { get; set; }
}
