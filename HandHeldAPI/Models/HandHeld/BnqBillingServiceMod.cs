using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingServiceMod
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? OtherSerCode { get; set; }

    public int? ServQty { get; set; }

    public double? ServRate { get; set; }

    public string? TaxStru { get; set; }

    public double? DiscPer { get; set; }

    public double? DiscAmt { get; set; }

    public DateTime? FDate { get; set; }

    public DateTime? ServDate { get; set; }

    public double? ServDiscount { get; set; }

    public short? EditNo { get; set; }
}
