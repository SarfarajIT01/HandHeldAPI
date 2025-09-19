using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoAdvertisement
{
    public string? AdvrType { get; set; }

    public string? AdvrName { get; set; }

    public DateTime? AdvrDate { get; set; }

    public string? Remark { get; set; }

    public string? NewsId { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
