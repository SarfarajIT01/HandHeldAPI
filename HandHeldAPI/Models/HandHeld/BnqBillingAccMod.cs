using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingAccMod
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? AccCode { get; set; }

    public double? Qty { get; set; }

    public double? AccRate { get; set; }

    public string? TaxStru { get; set; }

    public double? DiscPer { get; set; }

    public double? DiscAmt { get; set; }

    public DateTime? FDate { get; set; }

    public DateTime? AccDate { get; set; }

    public double? AccDiscount { get; set; }

    public short? EditNo { get; set; }
}
