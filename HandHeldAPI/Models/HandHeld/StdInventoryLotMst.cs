using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryLotMst
{
    public string? OutletId { get; set; }

    public string? LotNo { get; set; }

    public string? LocCode { get; set; }

    public string? ItemCode { get; set; }

    public string? TrnType { get; set; }

    public string? Refno { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public double? LotQty { get; set; }

    public double? BalLotQty { get; set; }

    public DateTime? LotExpiryDate { get; set; }

    public double? LotRate { get; set; }
}
