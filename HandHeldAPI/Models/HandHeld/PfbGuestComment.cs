using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbGuestComment
{
    public string? OutletId { get; set; }

    public string? GCode { get; set; }

    public DateTime? GDov { get; set; }

    public DateTime? GTov { get; set; }

    public string? GBill { get; set; }

    public string? GVisitAs { get; set; }

    public string? GFov { get; set; }

    public string? GNegC { get; set; }

    public string? GPosC { get; set; }

    public string? GComment { get; set; }

    // Newly added columns
    public string? Steward { get; set; }
    public string? TableName { get; set; }
    public short? NoPax { get; set; }
    public string? FoodQuality { get; set; }
    public string? ServiceQuality { get; set; }
    public string? DiningQuality { get; set; }
    public string? ReferenceBy { get; set; }
    public string? MResp { get; set; }
}



