using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingMenuRequiredGroup
{
    public int Id { get; set; }

    public string? ResNo { get; set; }

    public string? GroupCode { get; set; }

    public string? OutletCode { get; set; }
}
