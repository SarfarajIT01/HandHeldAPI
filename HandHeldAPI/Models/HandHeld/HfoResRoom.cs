using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResRoom
{
    public string? ResNo { get; set; }

    public string? RoomType { get; set; }

    public DateTime? Fdate { get; set; }

    public DateTime? Tdate { get; set; }

    public short? Rsno { get; set; }

    public string? RoomNo { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }
}
