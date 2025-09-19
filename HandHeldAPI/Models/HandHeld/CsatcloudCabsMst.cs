using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCabsMst
{
    public int Idd { get; set; }

    public string? OutletId { get; set; }

    public string? LocCode { get; set; }

    public string? Module { get; set; }

    public string? UnitName { get; set; }
}
