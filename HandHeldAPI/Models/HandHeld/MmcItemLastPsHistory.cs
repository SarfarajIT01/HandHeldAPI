using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcItemLastPsHistory
{
    public string? OutletId { get; set; }

    public string? LocationCode { get; set; }

    public string? ItemCode { get; set; }

    public string? TrnType { get; set; }

    public DateTime? LastDate { get; set; }

    public double? LastRate { get; set; }

    public string? LastVendor { get; set; }

    public string? CityCode { get; set; }
}
