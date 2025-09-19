using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbTableArrival
{
    public string? OutletId { get; set; }

    public string? RefNo { get; set; }

    public string? ArrivalTime { get; set; }

    public string? Pos { get; set; }

    public string? TableNo { get; set; }

    public string? GuestId { get; set; }

    public string? GuestName { get; set; }

    public string? BillNo { get; set; }

    public double? BillAmount { get; set; }

    public string? DepTime { get; set; }

    public string? Remark { get; set; }

    public DateTime? ArrDate { get; set; }

    public double? NofPax { get; set; }
}
