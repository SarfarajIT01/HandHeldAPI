using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestDisc
{
    public string? GuestId { get; set; }

    public string? Grno { get; set; }

    public DateTime? ArrDate { get; set; }

    public string? TrnType { get; set; }

    public float? Discvalue { get; set; }

    public string? Remark { get; set; }

    public string? GuestComp { get; set; }

    public string? GmembId { get; set; }

    public string? DailyDiscAmt { get; set; }

    public string? HotelCode { get; set; }

    public short? VisitNo { get; set; }

    public string? HfoGacid { get; set; }
}
