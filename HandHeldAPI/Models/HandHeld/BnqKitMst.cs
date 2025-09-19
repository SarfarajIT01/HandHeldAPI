using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqKitMst
{
    public string KitCode { get; set; } = null!;

    public string? KitDesc { get; set; }

    public string? KitKotPtrId { get; set; }

    public string? KitPosRem { get; set; }
}
