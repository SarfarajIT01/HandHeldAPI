using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class TempPosretComboOpen
{
    public string Category { get; set; } = null!;

    public string? Sno { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? Subcode { get; set; }

    public string? Qty { get; set; }

    public string? PriceBreakup { get; set; }
}
