using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class RtlAuditedDateLog
{
    public string? Pos { get; set; }

    public string? BillNo { get; set; }

    public DateTime? AuditedDat { get; set; }

    public string? Log { get; set; }

    public short? UniqId { get; set; }

    public DateTime? Date { get; set; }

    public string? Time { get; set; }

    public string? Ip { get; set; }
}
