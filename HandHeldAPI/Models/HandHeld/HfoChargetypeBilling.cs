using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoChargetypeBilling
{
    public int Id { get; set; }

    public string? ChargeType { get; set; }

    public float? Billing { get; set; }

    public string? Remark { get; set; }

    public string? TrnType { get; set; }

    public string? TrnRefNo { get; set; }

    public string? Status { get; set; }

    public string? OutletId { get; set; }
}
