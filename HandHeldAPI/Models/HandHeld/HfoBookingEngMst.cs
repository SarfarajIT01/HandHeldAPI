using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBookingEngMst
{
    public int Id { get; set; }

    public string? BkingId { get; set; }

    public string? BkingDesc { get; set; }

    public string? BkingPicture { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
