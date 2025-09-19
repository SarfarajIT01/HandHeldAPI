using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingMenuRequiredSubitem
{
    public int Id { get; set; }

    public string? ResNo { get; set; }

    public string? SubItemCode { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? OutletCode { get; set; }
}
