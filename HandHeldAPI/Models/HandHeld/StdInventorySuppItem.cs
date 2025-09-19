using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventorySuppItem
{
    public string? AccCode { get; set; }

    public string? AccType { get; set; }

    public string? ItemDesc { get; set; }

    public double? Rate { get; set; }

    public string? Remark { get; set; }

    public string? AccDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? AccCurr { get; set; }

    public string? TaxStat { get; set; }

    public DateTime? AsonDt { get; set; }

    public double? DpDays { get; set; }

    public string? SUom { get; set; }

    public string? SRefCode { get; set; }

    public double? Discount { get; set; }

    public string? PriceType { get; set; }

    public string? PackType { get; set; }

    public string? Brand { get; set; }

    public double? PackCost { get; set; }

    public double? OtherCost { get; set; }

    public double? PbvCost { get; set; }

    public string? CostBasis { get; set; }

    public string? DefSupp { get; set; }

    public double? MinOqty { get; set; }

    public double? SuppPrefe { get; set; }

    public string? OutletId { get; set; }
}
