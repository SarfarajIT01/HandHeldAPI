using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudModuleunit
{
    public int Idd { get; set; }

    public string? MasterCode { get; set; }

    public string? MasterType { get; set; }

    public string? ModuleCode { get; set; }

    public string? UnitId { get; set; }
}
