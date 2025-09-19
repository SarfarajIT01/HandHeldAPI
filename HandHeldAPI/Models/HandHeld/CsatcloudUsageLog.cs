using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudUsageLog
{
    

    public short Sno { get; set; }

    public string? Uid { get; set; }
    public string? OutletId { get; set; }

    public string? ModCode { get; set; }

    public string? SysIp { get; set; }

    public DateTime? Login { get; set; }

    public DateTime? Logout { get; set; }

    public string? SessionId { get; set; }
}
