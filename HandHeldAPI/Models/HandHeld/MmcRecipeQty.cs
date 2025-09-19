using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcRecipeQty
{
    public int Idd { get; set; }

    public string? OutletId { get; set; }

    public DateTime? Date1 { get; set; }

    public double? Qty1 { get; set; }

    public string? Item { get; set; }

    public string? Location { get; set; }

    public string? GicItem { get; set; }

    public double? Ratewouttax { get; set; }

    public double? Ratewtax { get; set; }

    public double? PlanQty { get; set; }

    public string? RmnuPom { get; set; }

    public string? GrpCod { get; set; }

    public double? Amount { get; set; }

    public double? CompQty { get; set; }

    public double? CompAmt { get; set; }

    public double? Discount { get; set; }
}
