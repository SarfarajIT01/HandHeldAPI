using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmTrnMst
{
    public string? GuestId { get; set; }

    public string? GcFlag { get; set; }

    public string? RefNo { get; set; }

    public string? CrmType { get; set; }

    public string? AmFlag { get; set; }

    public DateTime? RefDate { get; set; }

    public string? Loc { get; set; }

    public string? Mod1 { get; set; }

    public double? GrossAmt { get; set; }

    public double? NetAmt { get; set; }

    public double? PEarned { get; set; }

    public string? PRefno { get; set; }

    public string? CardNo { get; set; }

    public string? TransId { get; set; }

    public double? Discount { get; set; }

    public double? Tax { get; set; }

    public double? BaseAmt { get; set; }

    public int? Pax { get; set; }

    public string? Remark { get; set; }
}
