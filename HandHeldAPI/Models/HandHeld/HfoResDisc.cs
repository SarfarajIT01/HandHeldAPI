using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResDisc
{
    public string? ResNo { get; set; }

    public string? TrnType { get; set; }

    public float? DiscValue { get; set; }

    public string? GuestComp { get; set; }

    public string? Remark { get; set; }

    public string? HotelCode { get; set; }
}
