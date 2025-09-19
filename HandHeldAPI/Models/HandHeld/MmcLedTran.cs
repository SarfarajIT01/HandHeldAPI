using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcLedTran
{
    public int Idd { get; set; }

    public string? OutletId { get; set; }

    public string? GrefNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public int? GtrnCode { get; set; }

    public string? TrnTaxyn { get; set; }

    public double? GtrnAmt { get; set; }

    public double? GitemRat { get; set; }

    public double? GtrnQty { get; set; }

    public double? FreeQty { get; set; }

    public double? CostRate { get; set; }

    public double? GtrnValue { get; set; }

    public string? ItLcCode { get; set; }

    public string? ONo { get; set; }

    public short? NoPack { get; set; }

    public string? BatchNo { get; set; }

    public string? Make { get; set; }

    public double? BalQty { get; set; }

    public double? ItemTax { get; set; }

    public string? ItemCode { get; set; }

    public string? TrnType { get; set; }

    public string? PackType { get; set; }

    public double? PackQty { get; set; }

    public string? Remark { get; set; }

    public string? ModuleCode { get; set; }

    public double? RejectQty { get; set; }

    public DateTime? GicLotExpiryDate { get; set; }

    public double? ItemDis { get; set; }

    public string? Brand { get; set; }

    public string? LdgSeq { get; set; }

    public int? ItemSeq { get; set; }

    public string? StId { get; set; }

    public string? StDesc { get; set; }

    public string? OpenItemDesc { get; set; }

    public double? ItmDis { get; set; }

    public double? ItmTax { get; set; }

    public double? ItmRat { get; set; }

    public string? SCode { get; set; }

    public string? SName { get; set; }

    public string? CancelStatus { get; set; }

    public double? ItemExc { get; set; }

    public double? ItmExc { get; set; }

    public double? MitemRate { get; set; }

    public double? SitemRate { get; set; }

    public string? TaxstruCode { get; set; }

    public string? DiscCode { get; set; }

    public string? XmlPosted { get; set; }

    public double? ItemOth { get; set; }

    public double? ItmOth { get; set; }

    public double? ItemFinalAmt { get; set; }

    public string? ItemDisFlag { get; set; }

    public double? Rqty { get; set; }

    public double? EduCess { get; set; }

    public string? Outlet2Code { get; set; }

    public string? Location2Code { get; set; }
}
