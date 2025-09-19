using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillheadSetup
{
    public int Id { get; set; }

    public string? HmsHead { get; set; }

    public string? HmsDesc { get; set; }

    public bool? Tick { get; set; }

    public short? OrderNo { get; set; }

    public short? TrnOrderNo { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
