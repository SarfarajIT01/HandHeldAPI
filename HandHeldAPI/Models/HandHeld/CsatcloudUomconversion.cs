using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudUomconversion
{
    public int Id { get; set; }

    public string? FromUom { get; set; }

    public string? ToUom { get; set; }

    public decimal? Ratio1 { get; set; }

    public decimal? Ratio2 { get; set; }
}
