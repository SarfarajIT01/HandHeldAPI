using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbPersonal
{
    public int Idd { get; set; }

    public string? OutletId { get; set; }

    public string? EmpCode { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesc { get; set; }

    public string? UserId { get; set; }

    public string? CardId { get; set; }

    public float? EmpColor { get; set; }

    public string? EmpFname { get; set; }
}
