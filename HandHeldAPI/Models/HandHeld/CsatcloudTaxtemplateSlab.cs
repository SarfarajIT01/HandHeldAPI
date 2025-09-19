using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaxtemplateSlab
{
    public int Idd { get; set; }

    public DateTime? EffDate { get; set; }

    public string? TempCode { get; set; }

    public short? SrNo { get; set; }

    public double? FromAmount { get; set; }

    public double? ToAmount { get; set; }

    public string? CalType { get; set; }

    public float? Factor { get; set; }
}
