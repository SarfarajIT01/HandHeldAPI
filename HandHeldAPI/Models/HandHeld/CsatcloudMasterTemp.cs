using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMasterTemp
{
    public string? MasterTyp { get; set; }

    public string? OutletId { get; set; }

    public DateTime? ImpDate { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }
}
