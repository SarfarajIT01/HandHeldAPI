using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class Taxindex
{
    public string? Taxstrucode { get; set; }

    public string? Taxcode { get; set; }

    public float? Ratio4tax { get; set; }

    public float? Ratio4taxon { get; set; }

    public string? Taxtype { get; set; }

    public int? Countrow { get; set; }

    public int? Srno { get; set; }

    public int? Taxsrno { get; set; }

    public float? Df { get; set; }

    public int? Actsq { get; set; }
}
