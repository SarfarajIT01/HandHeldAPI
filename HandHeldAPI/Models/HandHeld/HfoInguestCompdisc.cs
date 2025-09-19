using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestCompdisc
{
    public string? GuestId { get; set; }

    public string? Grno { get; set; }

    public string? BillNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? TrnType { get; set; }

    public string? TrnRefNo { get; set; }

    public float? AllowedValue { get; set; }

    public float? AvailedValue { get; set; }

    public string? Remark { get; set; }

    public string? HotelCode { get; set; }

    public string? TrnStatus { get; set; }
}
