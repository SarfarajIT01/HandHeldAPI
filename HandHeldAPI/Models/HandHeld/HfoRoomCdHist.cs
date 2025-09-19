using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomCdHist
{
    public string? RoomNo { get; set; }

    public DateTime? OnDate { get; set; }

    public string? OnTime { get; set; }

    public string? Status { get; set; }

    public string? CleanBy { get; set; }

    public string? Remark { get; set; }

    public string? HotelCode { get; set; }

    public string? RoomStatus { get; set; }

    public string? Userid { get; set; }
}
