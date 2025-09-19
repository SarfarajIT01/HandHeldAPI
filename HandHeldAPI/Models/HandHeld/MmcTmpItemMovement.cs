using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTmpItemMovement
{
    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public string? LocationCode { get; set; }

    public string? ItmMoveMonth { get; set; }

    public short? ItmMoveYear { get; set; }

    public double? MOpeningBal { get; set; }

    public double? MIssue { get; set; }

    public double? MRec { get; set; }

    public double? MClosingBal { get; set; }

    public short? SerialNo { get; set; }

    public string? SystemIpAdd { get; set; }

    public string? TrnFlag { get; set; }

    public DateTime? TrnMonth { get; set; }

    public DateTime? PtrnAsOnDate { get; set; }

    public double? Qoh { get; set; }

    public double? PhyQoh { get; set; }

    public double? PtrnQty { get; set; }

    public string? MOpeningBal1 { get; set; }

    public string? MIssue1 { get; set; }

    public string? MRec1 { get; set; }

    public string? MClosingBal1 { get; set; }
}
