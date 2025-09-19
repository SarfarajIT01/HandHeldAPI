using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCommonGrpSubItem
{
    public int Idd { get; set; }

    public short? Id { get; set; }

    public string? ItemCode { get; set; }

    public string? GrpName { get; set; }

    public ulong? IsMulti { get; set; }

    public float? MinQty { get; set; }

    public float? MaxQty { get; set; }
}
