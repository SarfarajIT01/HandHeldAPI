using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbRcuMstOutlet
{
    public int Idd { get; set; }

    public string? RlocCod { get; set; }

    public string? OutletId { get; set; }

    public string? CuDesc { get; set; }

    public string? Active { get; set; }
}
