using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTaskwork
{
    public string WsId { get; set; } = null!;

    public string? WsTitle { get; set; }

    public string? WsUser { get; set; }

    public string? WsAct { get; set; }

    public string? WsRem { get; set; }

    public string? WsSts { get; set; }

    public short? WsQty { get; set; }
}
