using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudNotice
{
    public string NoticeCode { get; set; } = null!;

    public DateTime? NoticeDate { get; set; }

    public string? NoticeSub { get; set; }

    public string? NoticeMatter { get; set; }

    public string? NoticeStatus { get; set; }

    public string? UnitCode { get; set; }
}
