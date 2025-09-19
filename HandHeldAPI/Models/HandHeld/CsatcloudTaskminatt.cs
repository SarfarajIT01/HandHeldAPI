using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaskminatt
{
    public string WsId { get; set; } = null!;

    public string MajId { get; set; } = null!;

    public string MinId { get; set; } = null!;

    public string? MinName { get; set; }

    public string? MinSpe { get; set; }
}
