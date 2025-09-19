using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingMenuServedItem
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? OutletCode { get; set; }
}
