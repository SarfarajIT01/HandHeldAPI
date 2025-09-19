using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudUsermodule1
{
    public string UserId { get; set; } = null!;

    public string? ModuleId { get; set; }

    public string? Access { get; set; }

    public string? SubModuleId { get; set; }
}
