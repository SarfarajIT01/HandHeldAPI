using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbOrderMasterMapping
{
    public int Id { get; set; }

    public string? OutletId { get; set; }

    public string? Otypecode { get; set; }
}
