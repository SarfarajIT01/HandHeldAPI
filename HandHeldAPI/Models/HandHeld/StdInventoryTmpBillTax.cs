using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryTmpBillTax
{
    public string? OutletId { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public string? Pos { get; set; }

    public string? TaxName { get; set; }

    public double? TaxAmt { get; set; }

    public double? Tax { get; set; }

    public string? Charge { get; set; }

    public string? Reason { get; set; }

    public string? TCode { get; set; }

    public string? TType { get; set; }

    public string? SystemIpAddress { get; set; }

    public string? TaxOn { get; set; }
}
