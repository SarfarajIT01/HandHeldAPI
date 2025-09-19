using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CpfCommTmpStockValuation
{
    public string? OutletId { get; set; }

    public DateTime? OnDate { get; set; }

    public string? ItemCode { get; set; }

    public string? LocCode { get; set; }

    public double? CurrentBal { get; set; }

    public double? Lrate { get; set; }

    public string? ModuleCode { get; set; }

    public string? SystemIpAdd { get; set; }

    public double? CurrentBalNew { get; set; }
}
