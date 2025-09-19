using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqOpenItemMst
{
    public string ItemCode { get; set; } = null!;

    public string? ItemDesc { get; set; }

    public int? HsnCode { get; set; }

    public double? ItemRate { get; set; }

    public string? TaxStructure { get; set; }

    public string? Remark { get; set; }

    public string? Disable { get; set; }
}
