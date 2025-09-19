using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbRkotMan
{
    public string Kotno { get; set; } = null!;

    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public DateTime? KotDate { get; set; }

    public string? Code { get; set; }

    public string? Desci { get; set; }

    public string? DesOrrem { get; set; }

    public short? RkotSno { get; set; }
}
