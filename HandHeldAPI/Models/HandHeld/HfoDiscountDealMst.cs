using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoDiscountDealMst
{
    public int Id { get; set; }

    public string? DiscountId { get; set; }

    public string? DdDesc { get; set; }

    public string? DdStatus { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? OutletId { get; set; }
}
