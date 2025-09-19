using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDaybookMst
{
    public string? OutletId { get; set; }

    public string? Dbcode { get; set; }

    public string? Dbhead { get; set; }

    public string? Glcode { get; set; }

    public double? Minval { get; set; }

    public double? Maxval { get; set; }

    public double? DefVal { get; set; }
}
