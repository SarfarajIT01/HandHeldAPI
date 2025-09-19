using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoUndoLogTemp
{
    public string? BillNo { get; set; }

    public string? GuestId { get; set; }

    public DateTime? ArrDate { get; set; }

    public string? RoomNo { get; set; }

    public string? GuestName { get; set; }

    public short? Adult { get; set; }

    public double? Tarrif { get; set; }

    public string? ArrTime { get; set; }

    public short? VisitNo { get; set; }

    public string? Flag { get; set; }

    public DateTime? Undodate { get; set; }

    public string? Id { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }
}
