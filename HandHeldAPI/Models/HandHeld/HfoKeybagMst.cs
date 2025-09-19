using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoKeybagMst
{
    public short? KeyNum { get; set; }

    public DateTime? KeyDate { get; set; }

    public string? KeyTime { get; set; }

    public string? RoomNo { get; set; }

    public string? PaxSts { get; set; }

    public string? BagSts { get; set; }

    public string? ScantyBagSts { get; set; }

    public string? KeyBagRemark { get; set; }

    public string? GstSts { get; set; }

    public string? Grno { get; set; }
}
