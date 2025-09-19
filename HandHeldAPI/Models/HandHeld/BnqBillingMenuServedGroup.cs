using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingMenuServedGroup
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? GroupCode { get; set; }

    public string? OutletCode { get; set; }
}
