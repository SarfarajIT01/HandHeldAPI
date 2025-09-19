using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudLostFoundTrnarticle
{
    public string LostFoundId { get; set; } = null!;

    public string? Atype { get; set; }

    public string? Remark { get; set; }

    public short? Nos { get; set; }

    public double? Approxvalue { get; set; }

    public short? Sno { get; set; }

    public string? Flagtype { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? Memcode { get; set; }
}
