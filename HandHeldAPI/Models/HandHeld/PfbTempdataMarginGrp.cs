using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbTempdataMarginGrp
{
    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemGroup { get; set; }

    public string? Descript { get; set; }

    public decimal? CostPur { get; set; }

    public string? RkotMnu { get; set; }

    public decimal? RkotQty { get; set; }

    public decimal? RkotValue { get; set; }
}
