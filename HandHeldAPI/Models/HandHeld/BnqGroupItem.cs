using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqGroupItem
{
    public int Id { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }
}
