using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRefno2Setup
{
    public int Id { get; set; }

    public string? RefHead { get; set; }

    public string? RefType { get; set; }

    public string? RefNo { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }
}
