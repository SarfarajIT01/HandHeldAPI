using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaxcode
{
    public string TaxCode { get; set; } = null!;

    public DateTime EffDate { get; set; }

    public string? TaxName { get; set; }

    public string? TsName { get; set; }

    public string? TaxType { get; set; }

    public string? Taxsts { get; set; }
}
