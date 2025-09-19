using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcTmpCon1
{
    public string? OutletId { get; set; }

    public string? LocCode { get; set; }

    public string? ItemCode { get; set; }

    public double? ItemQty { get; set; }

    public string? SubItem { get; set; }

    public double? SubItemQty { get; set; }

    public double? SubItemRate { get; set; }

    public string? SubItemUom { get; set; }
}
