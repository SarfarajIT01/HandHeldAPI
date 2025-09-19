using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqTemplateInstruction
{
    public string TempCod { get; set; } = null!;

    public string? BillingIns { get; set; }

    public string? SplIns { get; set; }

    public string? Hk { get; set; }

    public string? Eng { get; set; }

    public string? Fo { get; set; }

    public string? Ec { get; set; }

    public string? Ths { get; set; }

    public string? Sec { get; set; }

    public string? Ks { get; set; }

    public string? Lobby { get; set; }

    public string? Oa { get; set; }
}
