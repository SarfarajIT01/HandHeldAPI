using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudComplain
{
    public string ComplNo { get; set; } = null!;

    public DateTime? ComplDate { get; set; }

    public string? ComplMemno { get; set; }

    public string? ComplStatus { get; set; }

    public string? ComplSub { get; set; }

    public DateTime? ComplClrdate { get; set; }

    public string? ComplDesc { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? Modcode { get; set; }

    public string? ComplType { get; set; }

    public string? ComplRemarks { get; set; }
}
