using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCompanysubmodule
{
    public string ModuleCode { get; set; } = null!;

    public string? Description { get; set; }

    public string SubModuleCode { get; set; } = null!;

    public string? Status { get; set; }
}
