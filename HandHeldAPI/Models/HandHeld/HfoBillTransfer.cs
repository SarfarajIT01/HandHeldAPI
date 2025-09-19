using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillTransfer
{
    public string? FromBillNo { get; set; }

    public string? ToBillNo { get; set; }

    public DateTime? TransDate { get; set; }

    public double? TransAmt { get; set; }

    public string? Remark { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }
}
