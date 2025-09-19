using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoReservationLetter
{
    public int Id { get; set; }

    public string? Subject { get; set; }

    public string? TopSection { get; set; }

    public string? BottomSection { get; set; }

    public string? LetterId { get; set; }

    public string? Operation { get; set; }

    public string? Attachfile { get; set; }

    public string? Process { get; set; }

    public ulong? Detailed { get; set; }
}
