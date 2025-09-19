using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItemSale
{
    public int Idd { get; set; }

    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public string? SUom { get; set; }

    public double? BSprice { get; set; }

    public double? MrpPrice { get; set; }

    public double? MSqty { get; set; }

    public string? SStat { get; set; }

    public string? STaxStruCode { get; set; }

    public string? ShelfDay { get; set; }
}
