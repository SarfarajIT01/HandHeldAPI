using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlCommGmscMst
{
    public string? OutletId { get; set; }

    public string? MscFlag { get; set; }

    public string? LocCode { get; set; }

    public string? MscCode { get; set; }

    public string? MscDesc { get; set; }

    public string? MscFdesc { get; set; }

    public string? MscAdd1 { get; set; }

    public string? MscAdd2 { get; set; }

    public string? PsAcc { get; set; }

    public double? MscMfact { get; set; }

    public string? MscVtype { get; set; }

    public string? MscVcode { get; set; }

    public string? MscUom { get; set; }

    public string? Increment { get; set; }

    public string? AutoRefno { get; set; }

    public string? AccCode { get; set; }

    public string? VouType { get; set; }

    public string? ItmTxdsc { get; set; }

    public double? TaxRound { get; set; }

    public double? DisRound { get; set; }

    public double? OnTot { get; set; }

    public string? DocType { get; set; }

    public string? FinDir { get; set; }

    public string? PrnSno { get; set; }

    public string? CstFrmrq { get; set; }

    public string? CstFrmtyp { get; set; }

    public DateTime? GicStdate { get; set; }

    public string? AccType { get; set; }

    public string? LocLotNo { get; set; }

    public string? ProdLocYn { get; set; }
}
