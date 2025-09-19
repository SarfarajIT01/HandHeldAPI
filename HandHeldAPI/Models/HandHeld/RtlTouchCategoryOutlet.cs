using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlTouchCategoryOutlet
{
    public string OutletId { get; set; } = null!;

    public string? Code { get; set; }

    public string? Name { get; set; }
}
