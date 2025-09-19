using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTmpWork
{
    public string? OutletId { get; set; }

    public string? ONo { get; set; }

    public string? WorkNo { get; set; }

    public string? ItemCode { get; set; }

    public double? OQty { get; set; }

    public double? Rate { get; set; }

    public string? Tax { get; set; }

    public double? Discount { get; set; }

    public double? OrdVal { get; set; }

    public double? TrnAmt { get; set; }

    public double? TaxAmt { get; set; }

    public double? DisAmt { get; set; }

    public double? OthAmt { get; set; }

    public int? ItemSeq { get; set; }

    public double? ExcAmt { get; set; }

    public string? LocCode { get; set; }
}
