using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTmpBillPrnTax
{
    public string? BillNo { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxName { get; set; }

    public double? TaxAmt { get; set; }

    public short? TaxSeq { get; set; }

    public double? TotAmt { get; set; }

    public double? Dbl1 { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }
}
