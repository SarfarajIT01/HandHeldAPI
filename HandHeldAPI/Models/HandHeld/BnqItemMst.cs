using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqItemMst
{
    public string ItemCode { get; set; } = null!;

    public string? ItemDesc { get; set; }

    public string? TaxStructure { get; set; }

    public string? ItemKitchen { get; set; }

    public short? Dorder { get; set; }

    public string? Remarks { get; set; }
}
