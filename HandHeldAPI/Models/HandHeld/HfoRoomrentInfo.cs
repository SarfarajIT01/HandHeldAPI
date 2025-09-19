using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomrentInfo
{
    public string? RoomNo { get; set; }

    public DateTime? WefDate { get; set; }

    public double? SingleBed { get; set; }

    public double? Doub { get; set; }

    public double? Minor { get; set; }

    public double? Extra { get; set; }

    public double? Infant { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
