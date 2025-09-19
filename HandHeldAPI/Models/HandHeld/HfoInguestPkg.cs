using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestPkg
{
    public string? GuestId { get; set; }

    public string? RoomNo { get; set; }

    public short? VisitNo { get; set; }

    public string? GmembId { get; set; }

    public string? PkgCode { get; set; }

    public string? TrnCode { get; set; }

    public string? TrnSubCode { get; set; }

    public decimal? TrnAmount { get; set; }

    public string? RoomType { get; set; }

    public string? TaxStru { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? HfoGacid { get; set; }
}
