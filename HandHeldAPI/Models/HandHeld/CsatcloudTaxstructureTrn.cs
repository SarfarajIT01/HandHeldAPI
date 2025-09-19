using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaxstructureTrn
{
    public int Idd { get; set; }

    public DateTime? EffDate { get; set; }

    public string? TaxStruCode { get; set; }

    public short? TaxSrNo { get; set; }

    public string? TaxCode { get; set; }

    public string? CalcType { get; set; }

    public string? Factor { get; set; }

    public string? TaxOn { get; set; }

    public string? Slab { get; set; }

    public short? TaxNo { get; set; }

    public string? Calculatedon { get; set; }

    public string? Stax { get; set; }

    public string? TaxOnDisc { get; set; }

    public double? Base { get; set; }
}
