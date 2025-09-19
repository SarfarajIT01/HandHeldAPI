using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGlobalonlineMst
{
    public string GlobalOnlineMstFlag { get; set; } = null!;

    public string GlobalOnlineMstCode { get; set; } = null!;

    public string? GlobalOnlineMstDesc { get; set; }

    public string? ModCode { get; set; }

    public string? Status { get; set; }

    public string? OutletId { get; set; }
}
