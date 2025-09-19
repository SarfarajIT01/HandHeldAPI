using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryLotTran
{
    public string? OutletId { get; set; }

    public string? LotNo { get; set; }

    public string? LocCode { get; set; }

    public string? ItemCode { get; set; }

    public string? TrnType { get; set; }

    public string? Refno { get; set; }

    public DateTime? TrnDate { get; set; }

    public double? LotQty { get; set; }

    public double? BalLotQty { get; set; }

    public double? TrnQty { get; set; }
}
