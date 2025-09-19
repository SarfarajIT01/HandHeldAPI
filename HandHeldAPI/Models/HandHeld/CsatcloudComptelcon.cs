using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudComptelcon
{
    public int Idd { get; set; }

    public string? CompCode { get; set; }

    public string? CompType { get; set; }

    public string? CommType { get; set; }

    public string? CommId { get; set; }

    public string? Remark { get; set; }
}
