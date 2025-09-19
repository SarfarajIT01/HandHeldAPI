using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoOccStatistic
{
    public string? RoomNo { get; set; }

    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? OccType { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public double? RecSum { get; set; }

    public double? BillSum { get; set; }
}
