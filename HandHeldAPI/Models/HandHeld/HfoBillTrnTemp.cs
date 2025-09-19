using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillTrnTemp
{
    public string? TrnRefNo { get; set; }

    public string? TrnType { get; set; }

    public DateTime? Trndate { get; set; }

    public float? Trnwwwate { get; set; }

    public float? TrnQty { get; set; }

    public float? TrnRate { get; set; }

    public float? Fd { get; set; }

    public float? Tl { get; set; }

    public float? Et { get; set; }

    public float? Lt { get; set; }

    public float? Ms { get; set; }

    public float? Lu { get; set; }

    public double? TotAmt { get; set; }

    public string? RoomNo { get; set; }

    public string? HotelCode { get; set; }

    public string? Guestcode { get; set; }
}
