using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlRkotItemSale
{
    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public DateTime? RkotDat { get; set; }

    public string? RkotMnu { get; set; }

    public decimal? RkotQty { get; set; }

    public decimal? RkotValue { get; set; }
}
