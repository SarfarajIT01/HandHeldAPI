using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryTempGlocMst
{
    public string? ItemCode { get; set; }

    public string? LocCode { get; set; }

    public double? ItemQoh { get; set; }

    public double? ItOpBal { get; set; }

    public double? TPurchase { get; set; }

    public double? TSale { get; set; }

    public double? TPoQty { get; set; }

    public string? SystemIpAdd { get; set; }
}
