using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudEmployee
{
    public string EmpId { get; set; } = null!;

    public string? EmpType { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? City { get; set; }

    public string? PhoneNo { get; set; }

    public string? MobNo { get; set; }

    public string? PinCode { get; set; }

    public string? EmpName { get; set; }

    public string? NickName { get; set; }

    public string? Status { get; set; }

    public string? Sex { get; set; }

    public string? Image { get; set; }

    public string? AutoIdCode { get; set; }

    public string? Emailid { get; set; }

    public string? EmpRemark { get; set; }
}
