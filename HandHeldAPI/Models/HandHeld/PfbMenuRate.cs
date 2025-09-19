using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbMenuRate
{
    public int RateId { get; set; }

    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public string? ItemCode { get; set; }

    public DateTime? FromDate { get; set; }

    public float? Rates { get; set; }

    public string? TaxType { get; set; }

    public string? RmnuTaxstrucode { get; set; }

    public string? RmnuAct { get; set; }

    public string? RmnuSubId { get; set; }

    public string? RmnuStax { get; set; }

    public float? MinRate { get; set; }

    public float? MaxRate { get; set; }
}
