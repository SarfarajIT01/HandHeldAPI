using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcSettleCode
{
    public string? SttCode { get; set; }

    public string? SttMode { get; set; }

    public string? SttName { get; set; }

    public double? SttComm { get; set; }

    public string? EstCode { get; set; }

    public string? SttLdgCode { get; set; }
}
