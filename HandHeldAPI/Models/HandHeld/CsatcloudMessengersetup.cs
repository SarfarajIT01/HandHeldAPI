using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMessengersetup
{
    public string SenderId { get; set; } = null!;

    public string? Smtp { get; set; }

    public short? Port { get; set; }

    public string? SenderPass { get; set; }

    public string? Status { get; set; }

    public string? Smsemailtype { get; set; }

    public string? Venderid { get; set; }

    public string? Userid { get; set; }

    public string? Flash { get; set; }

    public string? IsDefault { get; set; }

    public string? GatewayId { get; set; }

    public string? Module { get; set; }

    public string? Secure { get; set; }
}
