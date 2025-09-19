using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcIndentWsMst
{
    public string? IworkNo { get; set; }

    public string? IworkLoc { get; set; }

    public DateTime? IworkDate { get; set; }

    public string? IworkStatus { get; set; }

    public string? IworkFlag { get; set; }

    public string? Outlet { get; set; }
}
