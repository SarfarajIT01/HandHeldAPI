using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoVisitorTrn
{
    public string? TrnRefNo { get; set; }

    public string? VisitorName { get; set; }

    public string? CompCode { get; set; }

    public short? Pax { get; set; }

    public string? RecNo { get; set; }

    public string? CashMemoNo { get; set; }

    public string? TableNo { get; set; }

    public string? Mot { get; set; }

    public string? ContactNo { get; set; }

    public string? Guard { get; set; }

    public string? VregNo { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public DateTime? PlanDate { get; set; }
}
