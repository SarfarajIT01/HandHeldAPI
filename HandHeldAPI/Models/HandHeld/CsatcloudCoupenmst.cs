using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCoupenmst
{
    public string? Coupencode { get; set; }

    public string? Coupenname { get; set; }

    public string? CoupCurrency { get; set; }

    public short? CoupValue { get; set; }

    public string? Autorisedby { get; set; }

    public DateTime? Issuedate { get; set; }

    public DateTime? Validdate { get; set; }

    public string? Mulitplecoupen { get; set; }

    public string? Status { get; set; }

    public short? Coupencount { get; set; }

    public string? CoupSName { get; set; }

    public string? CoupRemark { get; set; }
}
