using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqServiceManagerMst
{
    public string? Department { get; set; }

    public string? Name { get; set; }

    public string? OutletCode { get; set; }

    public string InchargeCode { get; set; } = null!;
}
