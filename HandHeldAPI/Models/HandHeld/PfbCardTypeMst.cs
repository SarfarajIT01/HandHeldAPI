using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCardTypeMst
{
    public string? CType { get; set; }

    public string? CName { get; set; }

    public string? CFrom { get; set; }

    public string? CTo { get; set; }

    public string? CValid { get; set; }

    public string? CRnr { get; set; }

    public double? MinRef { get; set; }

    public double? MinVal { get; set; }

    public float? CardPeriod { get; set; }

    public string? MemCredit { get; set; }

    public string? ExpireOn { get; set; }
}
