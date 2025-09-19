using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMpdmst
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string Flag { get; set; } = null!;

    public string? Status { get; set; }

    public string? Remark { get; set; }
}
