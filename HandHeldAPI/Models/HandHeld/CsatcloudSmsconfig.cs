using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudSmsconfig
{
    public string? Type { get; set; }

    public string? ModCode { get; set; }

    public string? UnitCode { get; set; }

    public string? Eventype { get; set; }

    public string? Subject { get; set; }

    public string? Msglen { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }

    public string? Gatewayid { get; set; }

    public string? Password { get; set; }

    public string? Userid { get; set; }

    public string? Senderid { get; set; }

    public string? Status { get; set; }

    public string? Queue { get; set; }

    public string? Def { get; set; }
}
