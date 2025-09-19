using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbTemp
{
    public string? OutletId { get; set; }

    public string? Code { get; set; }

    public string? ItemGroup { get; set; }

    public string? Pos { get; set; }

    public string? Series { get; set; }

    public string? Currentno { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Currentdate { get; set; }

    public string? Ip { get; set; }

    public decimal? Discount { get; set; }

    public double? KotRat { get; set; }

    public double? TaxPerc { get; set; }

    public string? Remark { get; set; }

    public double? Qty { get; set; }
}
