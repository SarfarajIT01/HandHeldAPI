using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlTallyTemp
{
    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public DateTime? Date { get; set; }

    public string? Grpcat { get; set; }

    public string? ItemCode { get; set; }

    public double? ItemDisc { get; set; }

    public string? ItemTax { get; set; }

    public string? SettCode { get; set; }

    public double? ItemAmt { get; set; }
}
