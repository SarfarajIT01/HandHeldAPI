using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcRecipeMst
{
    public string ItemCode { get; set; } = null!;

    public string? ItemDesc { get; set; }

    public int? PortionSize { get; set; }

    public double? Overheads { get; set; }

    public double? OverAmt { get; set; }

    public double? ServedWeight { get; set; }

    public double? SaleRate { get; set; }

    public string? Remark { get; set; }

    public string? GrpCod { get; set; }

    public string? GrpName { get; set; }

    public string? RmnuPom { get; set; }

    public double? OvhAmt { get; set; }

    public string? CatCod { get; set; }

    public double? PorCost { get; set; }

    public double? PorWeight { get; set; }

    public double? PosfnbCost { get; set; }

    public string? RmsSaleFlag { get; set; }
}
