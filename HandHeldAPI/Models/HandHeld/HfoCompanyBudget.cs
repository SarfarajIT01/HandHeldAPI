using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCompanyBudget
{
    public string? OrgCode { get; set; }

    public string? OrgName { get; set; }

    public DateTime? FrDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Grade { get; set; }

    public double? ExpRev { get; set; }

    public short? Nights { get; set; }

    public string? Remark { get; set; }

    public string? OrgType { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
