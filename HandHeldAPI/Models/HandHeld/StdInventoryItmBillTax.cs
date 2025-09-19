using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItmBillTax
{
    public string? OutletId { get; set; }

    public string? RefNo { get; set; }

    public DateTime? RefDate { get; set; }

    public string? LocCode { get; set; }

    public string? TrnType { get; set; }

    public string? ItemCode { get; set; }

    public string? TaxCode { get; set; }

    public double? TaxAmt { get; set; }

    public string? SystemIpAddress { get; set; }
}
