using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqTemplateMst
{
    public string TempCod { get; set; } = null!;

    public string? TempDesc { get; set; }

    public string? Remark { get; set; }

    public string? MenuCard { get; set; }
}
