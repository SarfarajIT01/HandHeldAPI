using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqOtherServiceMst
{
    public string ServiceCode { get; set; } = null!;

    public string? ServiceDesc { get; set; }

    public string? HsnCode { get; set; }

    public double? ServiceRate { get; set; }

    public string? Remark { get; set; }

    public string? TaxStructure { get; set; }
}
