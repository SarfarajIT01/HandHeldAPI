using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudEmailconfig
{
    public string Subject { get; set; } = null!;

    public string? Message { get; set; }

    public string? Smtp { get; set; }

    public string? Port { get; set; }

    public string? SenderId { get; set; }

    public string? SenderPass { get; set; }

    public string? Status { get; set; }

    public string? Id { get; set; }
}
