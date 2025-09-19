using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoAutoPrintSetup
{
    public int Id { get; set; }

    public string? RepId { get; set; }

    public string? Repname { get; set; }

    public string? Groupname { get; set; }

    public bool? Selection { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
