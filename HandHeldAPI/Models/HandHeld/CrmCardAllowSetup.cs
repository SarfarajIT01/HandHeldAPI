using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmCardAllowSetup
{
    public string? OutLetId { get; set; }

    public string? CardCode { get; set; }

    public string? CardAllow { get; set; }

    public short? Discount { get; set; }

    public double? MinRedPoints { get; set; }

    public double? NoLoyPoint { get; set; }
}
