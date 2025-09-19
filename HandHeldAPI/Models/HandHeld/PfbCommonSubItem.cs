using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCommonSubItem
{
    public int Idd { get; set; }

    public string? Id { get; set; }

    public short? GrpId { get; set; }

    public string? SubName { get; set; }

    public float? SubColor { get; set; }
}
