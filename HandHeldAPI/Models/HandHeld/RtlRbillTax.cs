using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlRbillTax
{
    public string OutletId { get; set; } = null!;

    public string? RtaxPos { get; set; }

    public DateTime? RtaxDate { get; set; }

    public string? RtaxBill { get; set; }

    public string? RtaxStcode { get; set; }

    public string? RtaxTcode { get; set; }

    public double? RtaxOnAmt { get; set; }

    public double? RtaxTaxAmt { get; set; }

    public string? RtaxTaxTyp { get; set; }

    public string? RtaxChg { get; set; }

    public string? RtaxRsn { get; set; }
}
