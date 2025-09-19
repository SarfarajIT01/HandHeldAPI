using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoLaundryTrnRef
{
    public string? HotelCode { get; set; }

    public string? RefNo { get; set; }

    public string? GuestId { get; set; }

    public string? GuestName { get; set; }

    public short? VisitNo { get; set; }

    public string? RoomNo { get; set; }

    public string? MembId { get; set; }

    public DateTime? RefDate { get; set; }

    public string? RefTime { get; set; }

    public string? CollectBy { get; set; }

    public string? DeliFlag { get; set; }

    public string? SpecialIns { get; set; }

    public string? MarkId { get; set; }

    public string? Luflag { get; set; }
}
