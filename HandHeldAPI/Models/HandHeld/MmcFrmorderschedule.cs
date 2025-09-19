using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcFrmorderschedule
{
    public string? OutletId { get; set; }

    public string? ONo { get; set; }

    public string? TrnType { get; set; }

    public string? LocCode { get; set; }

    public double? Qty { get; set; }

    public string? Remark { get; set; }

    public string? ItemCode { get; set; }

    public DateTime? DDate { get; set; }

    public double? ORate { get; set; }
}
