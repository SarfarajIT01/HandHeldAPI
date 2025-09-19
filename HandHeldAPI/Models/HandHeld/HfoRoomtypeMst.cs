using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomtypeMst
{
    public int Id { get; set; }

    public string? RmtypeCode { get; set; }

    public string? Rmtype { get; set; }

    public string? SingleDouble { get; set; }

    public short? MaxPax { get; set; }

    public int? Tariff { get; set; }

    public short? ToTnor { get; set; }

    public short? Oblimit { get; set; }

    public string? ShortName { get; set; }

    public string? ExtraBedRent { get; set; }

    public int? MinorBedRent { get; set; }

    public int? InfantBedRent { get; set; }

    public int? SingleTariff { get; set; }

    public string? RoomPicture { get; set; }

    public string? LanguageInput { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? RoomNotes { get; set; }
}
