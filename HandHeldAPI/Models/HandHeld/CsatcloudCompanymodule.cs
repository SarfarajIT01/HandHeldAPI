using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCompanymodule
{
    public string ModuleCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? Unitid { get; set; }

    public string? CabsLink { get; set; }

    public string? Image { get; set; }
}
