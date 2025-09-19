using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryTmpRptDatum
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public double? OpnQty { get; set; }

    public double? RecQty { get; set; }

    public double? IssQty { get; set; }

    public string? LocCode { get; set; }

    public double? OpnAmt { get; set; }

    public double? AdjAmt { get; set; }

    public double? IssAmt { get; set; }

    public string? SystemIpAdd { get; set; }

    public double? ClQty { get; set; }

    public double? ClAmt { get; set; }

    public double? PurQty { get; set; }

    public double? PurAmt { get; set; }
}
