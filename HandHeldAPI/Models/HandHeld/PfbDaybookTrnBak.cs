using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDaybookTrnBak
{
    public string? OutletId { get; set; }

    public string? RefNo { get; set; }

    public string? SettleMode { get; set; }

    public DateTime? VouDate { get; set; }

    public string? Pos { get; set; }

    public string? Head { get; set; }

    public string? Narration { get; set; }

    public decimal? RecAmt { get; set; }

    public string? Gcode { get; set; }

    public string? PayRep { get; set; }

    public string? BillorVou { get; set; }

    public string? Cashier { get; set; }

    public decimal? PayAmt { get; set; }

    public string? TrnStatus { get; set; }

    public string? TrnReason { get; set; }

    public string? CardNo { get; set; }

    public double? SessionId { get; set; }
}
