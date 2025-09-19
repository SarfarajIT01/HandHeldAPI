using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class TempPosretComboFixed
{
    public string Sno { get; set; } = null!;

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? Qty { get; set; }

    public string? PriceBreakup { get; set; }

    public string? SubCode { get; set; }

    public string? ItemCode { get; set; }
}
