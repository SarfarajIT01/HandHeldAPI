using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudContactper
{
    public int Idd { get; set; }

    public string? CompCode { get; set; }

    public string? CompType { get; set; }

    public string? CpName { get; set; }

    public string? CpDesig { get; set; }

    public string? CpPhone { get; set; }

    public DateTime? CpDob { get; set; }

    public DateTime? CpDom { get; set; }

    public string? CpRemark { get; set; }
}
