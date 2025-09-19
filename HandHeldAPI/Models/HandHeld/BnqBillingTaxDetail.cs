using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBillingTaxDetail
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public string? TaxCode { get; set; }

    public double? TaxAmt { get; set; }

    public double? TaxCalculatedOnAmt { get; set; }

    public bool? IsChargeable { get; set; }

    public string? Remark { get; set; }

    public string? TaxType { get; set; }

    public short? EditNo { get; set; }
}
