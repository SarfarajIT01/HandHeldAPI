using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlSettlement
{
    public string SettlementCode { get; set; } = null!;

    public string? SettlementType { get; set; }

    public string? Description { get; set; }

    public decimal? Commission { get; set; }

    public string? Establishment { get; set; }

    public string? GlCode { get; set; }

    public string? TouchSettings { get; set; }

    public double? BackColor { get; set; }

    public string? FontName { get; set; }

    public short? FontSize { get; set; }

    public string? Status { get; set; }

    public string? RmscTyp { get; set; }
}
