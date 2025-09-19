using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudTableMst
{
    public string OutletId { get; set; } = null!;

    public string CsatcloudFlag { get; set; } = null!;

    public string CsatcloudCode { get; set; } = null!;

    public string? CsatcloudDesc { get; set; }

    public string? ModCode { get; set; }
}
