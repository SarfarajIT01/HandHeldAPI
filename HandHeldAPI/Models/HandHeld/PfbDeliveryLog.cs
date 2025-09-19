using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbDeliveryLog
{
    public string? Pos { get; set; }

    public string? RmsBilno { get; set; }

    public float RmsAmt { get; set; }

    public string RmsDelboy { get; set; } = null!;

    public string RmsOtime { get; set; } = null!;

    public DateTime? RmsStime { get; set; }

    public DateTime? RmsRtime { get; set; }

    public DateTime RmsDtime { get; set; }

    public DateTime RmsBdate { get; set; }

    public float? RmsCamt { get; set; }

    public float? RmsRamt { get; set; }

    public string? OutletId { get; set; }

    public string? ConfrmeOrd { get; set; }
}
