using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBookingEngTotalRoom
{
    public string? Unit { get; set; }

    public DateTime? Date { get; set; }

    public string? RoomType { get; set; }

    public string? TotalRoomHms { get; set; }

    public string? ArribalHms { get; set; }

    public string? DeparturesHms { get; set; }

    public string? OccupiedHms { get; set; }

    public string? VacantHms { get; set; }

    public string? ReservBookingEng { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
