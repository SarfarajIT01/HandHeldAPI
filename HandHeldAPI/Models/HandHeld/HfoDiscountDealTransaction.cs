using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoDiscountDealTransaction
{
    public int Id { get; set; }

    public string DdtCode { get; set; } = null!;

    public string DdtTrnType { get; set; } = null!;

    public decimal DdtDiscount { get; set; }

    public string? DdtRemark { get; set; }
}
