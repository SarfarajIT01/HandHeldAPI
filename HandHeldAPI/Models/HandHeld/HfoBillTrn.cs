using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillTrn
{
    public string? TrnRefNo { get; set; }

    public string? Pos { get; set; }

    public string? TrnSubHeadCode { get; set; }

    public string? TrnSubHeadDesc { get; set; }

    public float? TrnQty { get; set; }

    public float? TrnRate { get; set; }

    public string? Remarks { get; set; }

    public string? TaxType { get; set; }

    public float? Stax { get; set; }

    public float? Ltax { get; set; }

    public float? SurTax { get; set; }

    public float? Otax1 { get; set; }

    public float? Otax2 { get; set; }

    public float? StaxAmt { get; set; }

    public float? LtaxAmt { get; set; }

    public float? SurTaxAmt { get; set; }

    public float? Otax1Amt { get; set; }

    public float? Otax2Amt { get; set; }

    public float? DisPer { get; set; }

    public float? DisAmt { get; set; }

    public double? TotAmt { get; set; }

    public double? RtotAmt { get; set; }

    public DateTime? Trndate { get; set; }

    public string? TrnType { get; set; }

    public string? BillNo { get; set; }

    public string? SubHeadType { get; set; }

    public string? TrnStatus { get; set; }

    public string? TrnReason { get; set; }

    public string? OrgBillNo { get; set; }

    public float? AllowancePer { get; set; }

    public float? AllowanceAmt { get; set; }

    public string? TaxStru { get; set; }

    public double? RateBefore { get; set; }

    public string? BillRemarks { get; set; }

    public string? ModCode { get; set; }

    public double? PreReading { get; set; }

    public double? CurrReading { get; set; }

    public string? HotelCode { get; set; }

    public string? Scode { get; set; }
}
