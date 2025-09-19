using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqAccessoriesMst
{
    public string AccessCode { get; set; } = null!;

    public string? AccessDesc { get; set; }

    public int? AccessAvailQty { get; set; }

    public double? AccessRate { get; set; }

    public int? AccessHsnCode { get; set; }

    public string? TaxStructure { get; set; }
}
