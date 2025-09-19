using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlComment
{
    public string Parameter { get; set; } = null!;

    public string? Rating { get; set; }

    public string? Touchgroup { get; set; }
}
