using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMenuAccess
{
    public string? UserId { get; set; }

    public string? ModuleId { get; set; }

    public string? MenuValue { get; set; }

    public string? MenuAccess { get; set; }

    public string? MenuText { get; set; }
}
