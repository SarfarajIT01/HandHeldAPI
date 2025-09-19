using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoDailyOccupancyEntry
{
    public string? HotelName { get; set; }

    public DateTime? OccDate { get; set; }

    public string? RoomType { get; set; }

    public short? Nor { get; set; }

    public short? OccRoom { get; set; }

    public short? VacantRoom { get; set; }

    public short? BlockRoom { get; set; }

    public string? Reason { get; set; }

    public double? AvgRoomRev { get; set; }

    public string? Remark { get; set; }

    public string? AccountId { get; set; }
}
