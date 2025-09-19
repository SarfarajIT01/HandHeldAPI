using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGstdiscount
{
    public string Module { get; set; } = null!;

    public string? GstCode { get; set; }

    public DateTime? DiscValidDate { get; set; }

    public string? DiscPer { get; set; }
}
