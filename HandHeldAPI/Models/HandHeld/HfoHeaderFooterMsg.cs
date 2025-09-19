using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoHeaderFooterMsg
{
    public int Id { get; set; }

    public string? MessageType { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }
}
