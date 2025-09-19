using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CcaComPrinter
{
    public int Id { get; set; }

    public string? PrnOutletId { get; set; }

    public string? PrnModuleCode { get; set; }

    public string? PrnSetupTyp { get; set; }

    public bool? PrnCompanyName { get; set; }

    public bool? PrnUnitName { get; set; }

    public bool? PrnAdd { get; set; }

    public bool? PrnLogo { get; set; }

    public bool? PrnCity { get; set; }

    public bool? PrnPageNo { get; set; }

    public bool? PrnFilterOn { get; set; }

    public bool? PrnPrgbr { get; set; }

    public bool? PrnRptHeader { get; set; }

    public bool? PrnRptFooter { get; set; }

    public bool? PrnRptId { get; set; }

    public bool? PrnRptDt { get; set; }

    public bool? PrnPrintedBy { get; set; }

    public bool? PrnEndofRpt { get; set; }

    public bool? PrnEmail { get; set; }

    public bool? PrnMobileNo { get; set; }
}
