using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbOrdSum
{
    public string? OutletId { get; set; }

    public string? OsumPop { get; set; }

    public string? OsumNo { get; set; }

    public DateTime? OsumDat { get; set; }

    public string? OsumTim { get; set; }

    public decimal? OsumAmt { get; set; }

    public string? OsumGcd { get; set; }

    public string? OsumGcdName { get; set; }

    public string? OsumSts { get; set; }

    public string? OsumBil { get; set; }

    public string? OsumTyp { get; set; }

    public string? OsumCsh { get; set; }

    public string? OsumRem { get; set; }

    public string? OsumCshC { get; set; }

    public DateTime? OsumDdat { get; set; }

    public string? OsumDtim { get; set; }

    public double? OsumAdvAmt { get; set; }

    public string? OsumSmodeType { get; set; }

    public string? OsumSmodeCode { get; set; }

    public string? OsumCcno { get; set; }

    public string? OsumSplIns { get; set; }

    public string? OtherRefNo { get; set; }

    public string? OrderSource { get; set; }
}
