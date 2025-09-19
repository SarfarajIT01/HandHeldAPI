using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbItemRateDay
{
    public string? ItemCode { get; set; }

    public bool? Mon { get; set; }

    public bool? Tue { get; set; }

    public bool? Wed { get; set; }

    public bool? Thu { get; set; }

    public bool? Fri { get; set; }

    public bool? Sat { get; set; }

    public bool? Sun { get; set; }
}
