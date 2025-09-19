using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqEnquiryMenuRequiredGroup
{
    public int Id { get; set; }

    public string? EnqNo { get; set; }

    public string? GroupCode { get; set; }

    public string? OutletCode { get; set; }
}
