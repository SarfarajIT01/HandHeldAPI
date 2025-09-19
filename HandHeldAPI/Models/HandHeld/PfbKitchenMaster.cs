using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbKitchenMaster
{
    public string KitchenCode { get; set; } = null!;

    public string? OutletId { get; set; }

    public string? RlocTyp { get; set; }

    public string? Description { get; set; }

    public string? PosRemarks { get; set; }

    public string? ParentKitchenCode { get; set; }

    public string? OrderPrinter { get; set; }

    public string? Status { get; set; }

    public string? FillPoint { get; set; }
}
