using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomBlock
{
    public string? RoomNo { get; set; }

    public DateTime? BlockDate { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? BlockType { get; set; }

    public string? ResvNo { get; set; }

    public string? Reason { get; set; }

    public string? Remark { get; set; }

    public string? HotelCode { get; set; }
}
