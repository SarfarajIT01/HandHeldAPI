using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoDateChangePost
{
    public DateTime? RunDate { get; set; }

    public string? RoomNo { get; set; }

    public string? GuestId { get; set; }

    public string? Grno { get; set; }

    public string? GmembId { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
