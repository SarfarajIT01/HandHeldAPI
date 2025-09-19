using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoGuestMessage
{
    public string? HotelCode { get; set; }

    public string? RefNo { get; set; }

    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? RoomNo { get; set; }

    public string? MembId { get; set; }

    public string? FromWhom { get; set; }

    public string? Phone { get; set; }

    public string? Message { get; set; }

    public string? TakenBy { get; set; }

    public DateTime? OnDate { get; set; }

    public string? OnTime { get; set; }

    public string? DeliBy { get; set; }

    public DateTime? DeliDate { get; set; }

    public string? DeliTime { get; set; }

    public string? Remark { get; set; }

    public string? Mctype { get; set; }

    public string? Dept { get; set; }

    public string? Status { get; set; }
}
