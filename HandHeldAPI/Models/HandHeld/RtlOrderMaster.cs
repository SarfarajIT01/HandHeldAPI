using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlOrderMaster
{
    public string Otypecode { get; set; } = null!;

    public string? Description { get; set; }

    public float? Billing { get; set; }

    public string? Ordertype { get; set; }

    public string? Default1 { get; set; }

    public string? Ordergenerate { get; set; }

    public string? Status { get; set; }

    public string? Password { get; set; }

    public string? Passlevel { get; set; }
}
