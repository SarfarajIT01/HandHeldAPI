using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResRoomTemp
{
    public string? ResNo { get; set; }

    public string? RoomType { get; set; }

    public DateTime? ResDate { get; set; }

    public string? RoomNo { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public short? Adult { get; set; }
}
