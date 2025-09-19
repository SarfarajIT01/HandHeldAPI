using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlIpaddress
{
    public string ServerName { get; set; } = null!;

    public string? UserId { get; set; }

    public string? Pwd { get; set; }

    public string? IpAddress { get; set; }

    public string? DatabaseName { get; set; }
}
