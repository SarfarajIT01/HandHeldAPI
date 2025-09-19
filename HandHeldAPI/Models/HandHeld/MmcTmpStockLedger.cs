using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTmpStockLedger
{
    public string? OutletId { get; set; }

    public DateTime? F1 { get; set; }

    public double? F2 { get; set; }

    public double? F3 { get; set; }

    public double? F4 { get; set; }

    public double? F5 { get; set; }

    public string? ItemCode { get; set; }

    public string? ONo { get; set; }

    public string? TrnType { get; set; }

    public string? AccCode { get; set; }

    public double? BalQty { get; set; }

    public double? OpnQty { get; set; }

    public string? LocCode { get; set; }

    public string? ItemDesc { get; set; }

    public string? RefNo { get; set; }

    public string? CustDt { get; set; }

    public int? RecGroup { get; set; }

    public string? DateStr { get; set; }

    public string? ModuleCode { get; set; }

    public string? BillNo { get; set; }

    public string? IssueOn { get; set; }

    public string? SystemIpAdd { get; set; }

    public double? F6 { get; set; }

    public double? OpnQtyNew { get; set; }

    public double? BalQtyNew { get; set; }

    public double? F2New { get; set; }

    public double? F3New { get; set; }

    public string? ItemUom { get; set; }
}
