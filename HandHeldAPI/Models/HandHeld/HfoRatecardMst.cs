using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRatecardMst
{
    public int Id { get; set; }

    public string? RateCardCode { get; set; }

    public string? RateCardDesc { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Remark { get; set; }

    public string? RateCardSts { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }

    public string? BookingEng { get; set; }
}
