using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudDakRegister
{
    public string DakRefno { get; set; } = null!;

    public DateTime? DakDate { get; set; }

    public string? TimeIn { get; set; }

    public string? TimeOut { get; set; }

    public string? SentByCode { get; set; }

    public string? CompCode { get; set; }

    public string? DakSubject { get; set; }

    public string? DakMessage { get; set; }

    public string? RcvSentby { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? Modcode { get; set; }

    public string? SentbyType { get; set; }
}
