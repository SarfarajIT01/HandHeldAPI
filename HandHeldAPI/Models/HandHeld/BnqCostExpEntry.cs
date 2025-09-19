using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqCostExpEntry
{
    public string? BillNo { get; set; }

    public string? GuestId { get; set; }

    public string? Code { get; set; }

    public DateTime? EntryDate { get; set; }

    public double? Amount { get; set; }

    public string? Remarks { get; set; }
}
