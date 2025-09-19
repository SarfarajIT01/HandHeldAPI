using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlRkotTrnMod
{
    public string OutletId { get; set; } = null!;

    public string? RkotPop { get; set; }

    public string? RkotNo { get; set; }

    public string? RkotTyp { get; set; }

    public string? RkotMnu { get; set; }

    public decimal? RkotRat { get; set; }

    public decimal? RkotQty { get; set; }

    public decimal? RkotTax { get; set; }

    public short? RkotSno { get; set; }

    public DateTime? RkotDat { get; set; }

    public string? RkotTaxtyp { get; set; }

    public string? RkotRem { get; set; }

    public decimal? RkotWqty { get; set; }

    public decimal? RmnuRat { get; set; }

    public string? RkotType { get; set; }

    public decimal? RkotDisc { get; set; }

    public bool? RkotPost { get; set; }

    public string? RkotPrepTime { get; set; }

    public string? RkotPickTime { get; set; }

    public string? RkotAddon { get; set; }

    public DateTime? RkotServeTime { get; set; }

    public string? RkotStax { get; set; }

    public short? RkotSrNo { get; set; }

    public string? RkotCombo { get; set; }

    public string? RkotIsaddon { get; set; }

    public string? RkotIsSerChgFree { get; set; }

    public string? RkotSubItem { get; set; }

    public string? RkotModifier { get; set; }

    public string? ComboCode { get; set; }

    public string? ComboFlag { get; set; }

    public decimal? FnlBaseVal { get; set; }

    public decimal? DiscAmt { get; set; }

    public decimal? RkotSurc { get; set; }
}
