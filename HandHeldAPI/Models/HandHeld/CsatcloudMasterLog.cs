using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMasterLog
{
    public short Sno { get; set; }

    public string? Uid { get; set; }

    public string? ModCode { get; set; }

    public string? SysIp { get; set; }

    public DateTime? ChDateTime { get; set; }

    public string? MstType { get; set; }

    public string? SessionId { get; set; }

    public string? MstCode { get; set; }

    public string? Remark { get; set; }
}
