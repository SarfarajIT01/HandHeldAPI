using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbTouchCategoryMap
{
    public int Idd { get; set; }

    public string? CutCode { get; set; }

    public string? OutletId { get; set; }

    public string? PosCode { get; set; }

    public string? ActiveFlag { get; set; }
}
