using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomStatus
{
    public string? Unitid { get; set; }

    public string? RoomTyp { get; set; }

    public string? Doh { get; set; }

    public string? OooRoom { get; set; }

    public string? DirectArrive { get; set; }

    public string? ResvArrive { get; set; }

    public string? DirectCheckout { get; set; }

    public string? ReservCheckout { get; set; }
}
