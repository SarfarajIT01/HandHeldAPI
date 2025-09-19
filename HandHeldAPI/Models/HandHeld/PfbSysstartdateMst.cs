using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbSysstartdateMst
{
    public string OutletId { get; set; } = null!;

    public DateTime? Stdate { get; set; }

    public DateTime? RunDate { get; set; }
}
