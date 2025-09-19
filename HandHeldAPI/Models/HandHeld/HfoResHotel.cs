using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResHotel
{
    public string? ResNo { get; set; }

    public string? StsFlag { get; set; }

    public short? Adult { get; set; }

    public short? Minor { get; set; }

    public short? Infant { get; set; }

    public string? RoomType { get; set; }

    public short? Nor { get; set; }

    public DateTime? FromDate { get; set; }

    public string? ArrFrom { get; set; }

    public string? ArrMode { get; set; }

    public string? ArrTime { get; set; }

    public DateTime? ToDate { get; set; }

    public string? DepTo { get; set; }

    public string? DepMode { get; set; }

    public string? DepTime { get; set; }

    public string? Tariff { get; set; }

    public DateTime? Cddate { get; set; }

    public string? Cdexecutive { get; set; }

    public string? Cdreason { get; set; }

    public string? RoomRemark { get; set; }

    public string? StayType { get; set; }

    public string? Cdtime { get; set; }

    public string? BedType { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? HfoGacid { get; set; }
}
