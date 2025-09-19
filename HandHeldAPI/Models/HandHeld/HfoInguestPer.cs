using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestPer
{
    public string? GuestId { get; set; }

    public byte? Age { get; set; }

    public DateTime? Dob { get; set; }

    public string? SpouseName { get; set; }

    public DateTime? Dom { get; set; }

    public string? Glikes { get; set; }

    public string? GdisLikes { get; set; }

    public string? Gspns { get; set; }

    public string? Photo { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
