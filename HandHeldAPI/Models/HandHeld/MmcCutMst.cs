using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcCutMst
{
    public string CutCode { get; set; } = null!;

    public string CutFlag { get; set; } = null!;

    public string? CutDesc { get; set; }

    public string? ChirLevel { get; set; }

    public short? CnoofItem { get; set; }

    public float? CutPercn { get; set; }

    public string? CutGlcod { get; set; }

    public string? CutTrntp { get; set; }

    public string? GrpUnder { get; set; }

    public string? CutCnfact { get; set; }

    public string? LedgerCode { get; set; }

    public string? CutDis { get; set; }

    public string? CutTax { get; set; }

    public string? CutExc { get; set; }

    public string? TallyLedgerName { get; set; }

    public string? TallyPurLedgerName { get; set; }

    public string? TallySalLedgerName { get; set; }

    public string? Status { get; set; }
}
