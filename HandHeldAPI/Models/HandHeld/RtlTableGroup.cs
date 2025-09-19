using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlTableGroup
{
    public string Pos { get; set; } = null!;

    public string? Tablegroup { get; set; }

    public string? Tables { get; set; }
}
