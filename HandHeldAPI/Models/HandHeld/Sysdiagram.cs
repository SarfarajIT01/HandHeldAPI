using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class Sysdiagram
{
    public int DiagramId { get; set; }

    public string Name { get; set; } = null!;

    public int PrincipalId { get; set; }

    public int? Version { get; set; }

    public byte[]? Definition { get; set; }
}
