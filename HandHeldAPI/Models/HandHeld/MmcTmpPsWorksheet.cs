using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTmpPsWorksheet
{
    public DateTime? PtrnAsOnDate { get; set; }

    public string? LocationCode { get; set; }

    public short? SerialNo { get; set; }

    public string? ItemCode { get; set; }

    public double? Qoh { get; set; }

    public double? PhyQoh { get; set; }
}
