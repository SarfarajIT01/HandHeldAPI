using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbUserPermission
{
    public string? OutletId { get; set; }

    public string? UserId { get; set; }

    public string? Menu { get; set; }

    public string? Value { get; set; }
}
