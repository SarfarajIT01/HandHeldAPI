using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcGlocMst
{
    public int Idd { get; set; }

    public string? OutletId { get; set; }

    public string? ItemCode { get; set; }

    public string? LocCode { get; set; }

    public double? ItYrRcp { get; set; }

    public double? ItYrIss { get; set; }

    public double? ItemQoh { get; set; }

    public double? LotQoh { get; set; }

    public DateTime? ItLsRcdt { get; set; }

    public DateTime? ItLsIsdt { get; set; }

    public double? ItLsRqty { get; set; }

    public double? PuOrdQty { get; set; }

    public double? ItLsIqty { get; set; }

    public int? SaOrdQty { get; set; }

    public double? PtdQty { get; set; }

    public double? PtdSaVal { get; set; }

    public double? PtdCoVal { get; set; }

    public int? YtdQty { get; set; }

    public double? YtdSaVal { get; set; }

    public double? YtdCoVal { get; set; }

    public int? ItLyrRcp { get; set; }

    public double? ItLyrSal { get; set; }

    public double? ItLyrCos { get; set; }

    public int? ItPhyQty { get; set; }

    public double? BookQty { get; set; }

    public double? LastRrate { get; set; }

    public double? ItOpBal { get; set; }

    public double? PhyQoh { get; set; }

    public DateTime? PhyAsOnDate { get; set; }

    public string? ItemOnLocation { get; set; }

    public double? OpRate { get; set; }

    public double? ItMnLevl { get; set; }

    public double? ItMxLevl { get; set; }

    public double? ItRoLevl { get; set; }

    public double? ItRoQty { get; set; }

    public double? ItemQohNew { get; set; }

    public double? PsPlus { get; set; }

    public double? PsMinus { get; set; }

    public double? PsOpBal { get; set; }
}
