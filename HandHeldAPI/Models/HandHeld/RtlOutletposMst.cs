using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlOutletposMst
{
    public string OutletId { get; set; } = null!;

    public string? PosCode { get; set; }

    public string? PosDesc { get; set; }

    public string? PosType { get; set; }

    public string? Vatno { get; set; }

    public string? Cstno { get; set; }

    public string? DefsetCode { get; set; }

    public string? Status { get; set; }

    public string? NoGeneration { get; set; }

    public string? OrderSavePrint { get; set; }

    public string? OrderType { get; set; }

    public string? BillType { get; set; }

    public string? LfBefore { get; set; }

    public string? Orderprinting { get; set; }

    public string? Billprinting { get; set; }

    public string? LfAfter { get; set; }

    public string? Copies { get; set; }

    public string? After { get; set; }

    public string? RlocHeader { get; set; }

    public string? RlocTrailor { get; set; }

    public string? RmsPackType { get; set; }

    public string? RlocTbl { get; set; }

    public string? RlocCkot { get; set; }
}
