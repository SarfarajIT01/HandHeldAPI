using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItemSummaryMst
{
    public string? ItemCode { get; set; }

    public string? ItemBasisOf { get; set; }

    public string? ItemDimensional { get; set; }

    public string? ItemFitment { get; set; }

    public string? ItemComplaint { get; set; }

    public string? ItemOthers { get; set; }

    public string? MasterSample { get; set; }

    public string? StdProduct { get; set; }

    public string? Description { get; set; }

    public string? Specification { get; set; }

    public string? IssueNo { get; set; }

    public DateTime? IssuedOn { get; set; }

    public string? SplIns { get; set; }
}
