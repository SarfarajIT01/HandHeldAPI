using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoVipCat
{
    public int Id { get; set; }

    public string? CsatcloudId { get; set; }

    public string? CsatcloudFlag { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
