using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryBinItemBalance
{
    public string? OutletId { get; set; }

    public string? BinCode { get; set; }

    public string? TrnType { get; set; }

    public string? TrnRefNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? ItemCode { get; set; }

    public double? ItemTrnQty { get; set; }

    public string? LocCode { get; set; }

    public string? BinPRRefno { get; set; }

    public DateTime? BinPRDate { get; set; }
}
