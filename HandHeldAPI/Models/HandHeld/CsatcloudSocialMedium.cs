using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudSocialMedium
{
    public string Code { get; set; } = null!;

    public string? Url { get; set; }

    public string? PageId { get; set; }

    public string? UserId { get; set; }

    public string? Pwd { get; set; }

    public string? AboutIt { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public string? OutletId { get; set; }

    public string? ModuleCode { get; set; }
}
