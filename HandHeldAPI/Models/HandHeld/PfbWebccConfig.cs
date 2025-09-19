using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbWebccConfig
{
    public string Outletid { get; set; } = null!;

    public string? WebPos { get; set; }

    public string? Ccpos { get; set; }

    public string? DataShink { get; set; }
}
