using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudComcardmst
{
    public string CcPara { get; set; } = null!;

    public string? CcRating { get; set; }

    public string? CcFlag { get; set; }

    public string Status { get; set; } = null!;
}
