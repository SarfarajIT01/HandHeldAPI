using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlTouchCategoryMap
{
    public string OutletId { get; set; } = null!;

    public string? PosCode { get; set; }

    public string? ActiveFlag { get; set; }

    public string? CutCode { get; set; }
}
