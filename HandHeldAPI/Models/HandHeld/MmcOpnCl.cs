using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcOpnCl
{
    public string? OutletId { get; set; }

    public DateTime? ItDate { get; set; }

    public string? ItemFlag { get; set; }

    public string? ItemCode { get; set; }

    public string? LocCode { get; set; }

    public double? ItemQoh { get; set; }

    public double? ItOpBal { get; set; }

    public string? EmpCode { get; set; }

    public string? Remark { get; set; }
}
