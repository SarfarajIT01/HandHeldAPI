using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcAuthMap
{
    public string? OutletId { get; set; }

    public string? LocCode { get; set; }

    public string? Pos { get; set; }

    public string? PosKitchen { get; set; }

    public string? DefaultLoc { get; set; }
}
