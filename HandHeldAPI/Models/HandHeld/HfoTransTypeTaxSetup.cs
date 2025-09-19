using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTransTypeTaxSetup
{
    public int Id { get; set; }

    public string? TrnType { get; set; }

    public bool? A { get; set; }

    public bool? B { get; set; }

    public bool? C { get; set; }

    public bool? D { get; set; }

    public bool? E { get; set; }

    public bool? F { get; set; }

    public bool? G { get; set; }

    public bool? H { get; set; }

    public string? OutletId { get; set; }
}
