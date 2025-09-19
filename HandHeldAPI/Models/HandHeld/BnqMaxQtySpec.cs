using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqMaxQtySpec
{
    public string SelectionCode { get; set; } = null!;

    public string? SelectionDesc { get; set; }

    public int? Rate { get; set; }

    public string? TaxStructure { get; set; }
}
