using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCoupontrn
{
    public string? CouponTypeCode { get; set; }

    public string CouponNo { get; set; } = null!;

    public string? CValueOn { get; set; }

    public string? CValue { get; set; }

    public string? IssuesTo { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? IssueBy { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? OutletId { get; set; }

    public string? RedeemModule { get; set; }

    public DateTime? RedeemDate { get; set; }

    public string? RefNo { get; set; }

    public string? Amount { get; set; }

    public string? IpAdd { get; set; }
}
