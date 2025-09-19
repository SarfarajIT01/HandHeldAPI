using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCompagentBaDetailTemp
{
    public string? CompCode { get; set; }

    public string? BillNo { get; set; }

    public double? BillAmt { get; set; }

    public double? RecAmt { get; set; }

    public DateTime? ArrDt { get; set; }

    public DateTime? DepDt { get; set; }

    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? GuestName { get; set; }

    public double? RentAmt { get; set; }

    public double? LuxAmt { get; set; }

    public double? FoodAmt { get; set; }

    public double? StAmt { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
