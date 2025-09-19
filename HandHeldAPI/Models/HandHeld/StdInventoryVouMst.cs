using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class StdInventoryVouMst
{
    public string? OutletId { get; set; }

    public string? VouCode { get; set; }

    public string? VouName { get; set; }

    public string? VouClass { get; set; }

    public string? CcClass { get; set; }

    public string? VouLocCode { get; set; }
}
