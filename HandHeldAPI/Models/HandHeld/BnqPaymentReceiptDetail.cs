using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqPaymentReceiptDetail
{
    public string? RecNo { get; set; }

    public DateTime? RecDate { get; set; }

    public double? RecAmt { get; set; }

    public string? BillNo { get; set; }

    public string? RecRefFlag { get; set; }

    public string? RecStatus { get; set; }
}
