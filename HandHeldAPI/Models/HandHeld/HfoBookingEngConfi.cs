using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBookingEngConfi
{
    public int Id { get; set; }

    public string? CacelPolice { get; set; }

    public string? DepositPolice { get; set; }

    public string? HotelNo { get; set; }

    public string? CutofHour { get; set; }

    public string? StayPeriod { get; set; }

    public string? Remark { get; set; }

    public string? AddOnService { get; set; }

    public string? ReservPolice { get; set; }

    public string? StayPeriodMax { get; set; }

    public string? ServerName { get; set; }

    public string? UserName { get; set; }

    public string? Password1 { get; set; }

    public string? DbName { get; set; }

    public string? CompId { get; set; }

    public string? OutletId { get; set; }

    public string? ServicePath { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public DateTime? MaxResvDate { get; set; }

    public string? UnitCode { get; set; }

    public string? CancelPolice { get; set; }

    public DateTime? MinResvDate { get; set; }

    public short? MaxResDays { get; set; }

    public short? StayMaxPeriod { get; set; }

    public string? ClientId { get; set; }
}
