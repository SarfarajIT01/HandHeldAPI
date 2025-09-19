using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItemPtype
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public string? PartyType { get; set; }

    public double? PRate { get; set; }
}
