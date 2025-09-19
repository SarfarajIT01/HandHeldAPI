using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaxstructure
{
    public string TaxStruCode { get; set; } = null!;

    public DateTime EffDate { get; set; }

    public string? TaxStruName { get; set; }

    public string? TaxType { get; set; }

    public string? TaxSts { get; set; }
}
