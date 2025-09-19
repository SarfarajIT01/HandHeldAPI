using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcCardtypeMst
{
    public string? CardId { get; set; }

    public string? CardName { get; set; }

    public string? CardType { get; set; }

    public string? ItemCode { get; set; }

    public string? Descript { get; set; }

    public string? ItmCtgry { get; set; }

    public double? Rate { get; set; }

    public string? Taxstrucode { get; set; }

    public string? Flag { get; set; }

    public string? TaxTyp { get; set; }
}
