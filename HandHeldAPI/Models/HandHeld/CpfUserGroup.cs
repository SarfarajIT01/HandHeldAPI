using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CpfUserGroup
{
    public string? CompCode { get; set; }

    public short? GrCode { get; set; }

    public string? GrDesc { get; set; }

    public string? GrRemark { get; set; }

    public string? GrSts { get; set; }

    public string? GrLvl { get; set; }

    public string? GrImg { get; set; }
}
