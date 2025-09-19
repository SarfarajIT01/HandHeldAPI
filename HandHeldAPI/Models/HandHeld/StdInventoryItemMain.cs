using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryItemMain
{
    public string ItemCode { get; set; } = null!;

    public string? ItemDesc { get; set; }

    public string? SrtCode { get; set; }

    public string? ItmCtgry { get; set; }

    public string? ItemUom { get; set; }

    public string? SubUom { get; set; }

    public string? ItemClass { get; set; }

    public string? MatType { get; set; }

    public string? PicType { get; set; }

    public string? ItPhoto { get; set; }

    public string? OpenItem { get; set; }

    public string? SUom { get; set; }

    public double? ItemCost { get; set; }

    public string? STaxStruCode { get; set; }

    public double? BasePrice { get; set; }

    public string? GrpCode { get; set; }

    public string? Brand { get; set; }
}
