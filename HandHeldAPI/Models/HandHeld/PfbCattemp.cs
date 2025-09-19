using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCattemp
{
    public string? ItemCode { get; set; }

    public string? Descript { get; set; }

    public decimal? Rate { get; set; }

    public string? Quantity { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Taxes { get; set; }

    public decimal? TotalAmt { get; set; }

    public string? Outlet { get; set; }

    public string? Pos { get; set; }

    public string? Category { get; set; }
}
