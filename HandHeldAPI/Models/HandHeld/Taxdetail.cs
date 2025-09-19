using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class Taxdetail
{
    public string? Taxcode { get; set; }

    public float? Taxon { get; set; }

    public float? Taxamt { get; set; }

    public string? Taxtype { get; set; }

    public string? Taxorder { get; set; }

    public string? Taxord { get; set; }
}
