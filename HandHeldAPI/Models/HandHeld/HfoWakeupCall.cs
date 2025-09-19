using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoWakeupCall
{
    public string? RefNo { get; set; }

    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? RoomNo { get; set; }

    public string? MembId { get; set; }

    public string? Message { get; set; }

    public DateTime? OnDate { get; set; }

    public string? OnTime { get; set; }

    public DateTime? ReqDate { get; set; }

    public string? ReqTime { get; set; }

    public string? CallType { get; set; }

    public string? Status { get; set; }
}
