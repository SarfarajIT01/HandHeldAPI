using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBookingEngLoginLog
{
    public string? Ip { get; set; }

    public DateTime? Date { get; set; }

    public string? Time { get; set; }

    public string? Remark { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
