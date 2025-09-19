using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCompRoomAllocation
{
    public string? HotelCode { get; set; }

    public string? OrgCode { get; set; }

    public string? OrgName { get; set; }

    public DateTime? FrDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? RoomType { get; set; }

    public short? ForcastRoom { get; set; }

    public double? TarrifRs { get; set; }

    public double? TarrifOth { get; set; }

    public string? OthCurr { get; set; }

    public string? OrgType { get; set; }
}
