using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoReceiptTrn
{
    public string? RecNo { get; set; }

    public DateTime? RecDate { get; set; }

    public double? RecAmt { get; set; }

    public string? BillNo { get; set; }

    public string? RecRefFlag { get; set; }

    public string? RecStatus { get; set; }

    public DateTime? InputRundate { get; set; }

    public string? RecTime { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
