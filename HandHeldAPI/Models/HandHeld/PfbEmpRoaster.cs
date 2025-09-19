using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbEmpRoaster
{
    public string? OutletId { get; set; }

    public DateTime? EDate { get; set; }

    public string? Shift { get; set; }

    public string? ECode { get; set; }

    public string? Type { get; set; }

    public string? Present { get; set; }

    public string? Remark { get; set; }
}
