using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqRoomGuest
{
    public string? GuestCode { get; set; }

    public string? GName { get; set; }

    public string? Firstname { get; set; }

    public string? Middlename { get; set; }

    public DateTime? GAdate { get; set; }

    public DateTime? GDDate { get; set; }

    public string? GSts { get; set; }

    public string? RoomNo { get; set; }

    public string? GFlag { get; set; }

    public string? CompanyName { get; set; }

    public string? Billinginstructions { get; set; }
}
