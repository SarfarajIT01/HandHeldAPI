using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCoupontype
{
    public string CouponTypeCode { get; set; } = null!;

    public string? CouponDesc { get; set; }

    public string? CValueOn { get; set; }

    public string? CValue { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? CouponOn { get; set; }

    public string? ModuleCode { get; set; }
}
