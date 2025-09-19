using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbComboMst
{
    public int Idd { get; set; }

    public string? ComboCode { get; set; }

    public decimal? ItemQty { get; set; }

    public string? ItemCode { get; set; }

    public string? Pos { get; set; }

    public string? Status { get; set; }

    public double? Rate { get; set; }

    public DateTime? FromDate { get; set; }

    public string? ItemCat { get; set; }

    public string? ComboFlag { get; set; }

    public short? ItemSeq { get; set; }

    public string? SubCode { get; set; }

    public double? SubRate { get; set; }

    public short? CatQty { get; set; }
}
