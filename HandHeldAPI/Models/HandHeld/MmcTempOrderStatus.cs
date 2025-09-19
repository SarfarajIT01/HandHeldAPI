using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTempOrderStatus
{
    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public string? CataloguesNo { get; set; }

    public string? Sample { get; set; }

    public double? SorderQty { get; set; }

    public double? PorderQty { get; set; }

    public double? Qoh { get; set; }

    public string? LocCode { get; set; }

    public double? Balance { get; set; }

    public double? Mlevel { get; set; }

    public string? VendorDesc { get; set; }

    public string? SystemIpAdd { get; set; }
}
