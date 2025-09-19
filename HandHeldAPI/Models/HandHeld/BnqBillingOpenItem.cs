using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingOpenItem
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? ItemCode { get; set; }

    public double? ItemRate { get; set; }

    public double? Qty { get; set; }

    public string? TaxStru { get; set; }

    public double? DiscPer { get; set; }

    public double? DiscAmt { get; set; }

    public string? ItemDesc { get; set; }

    public DateTime? FDate { get; set; }

    public DateTime? OpenDate { get; set; }

    public string? OutletCode { get; set; }
}
