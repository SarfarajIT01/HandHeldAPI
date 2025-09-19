using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbPassword
{
    public string? OutletId { get; set; }

    public string? CompanyCode { get; set; }

    public string? OperatorId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public string? UserHierarchy { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? UserGroup { get; set; }

    public string? EmpId { get; set; }

    public string? ModuleCode { get; set; }

    public string? Status { get; set; }
}
