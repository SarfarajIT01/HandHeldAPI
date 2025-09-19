using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingTaxDetail
{
    public string? ResNo { get; set; }

    public DateTime? ResDate { get; set; }

    public string? TaxCode { get; set; }

    public double? TaxAmt { get; set; }

    public double? TaxCalculatedOnAmt { get; set; }

    public bool? IsChargeable { get; set; }

    public string? Remark { get; set; }

    public string? TaxType { get; set; }
}
