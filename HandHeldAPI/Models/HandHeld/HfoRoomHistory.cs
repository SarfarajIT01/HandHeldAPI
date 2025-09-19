using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomHistory
{
    public string? RoomNo { get; set; }

    public string? GuestId { get; set; }

    public string? GmemId { get; set; }

    public DateTime? ArrDate { get; set; }

    public string? ArrTime { get; set; }

    public short? VisitNo { get; set; }

    public DateTime? DepDate { get; set; }

    public string? DepTime { get; set; }

    public double? Ntarrif { get; set; }

    public string? TransferReason { get; set; }

    public string? UndoReason { get; set; }

    public string? TrnasUserId { get; set; }

    public string? GuestName { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? HfoGacid { get; set; }
}
