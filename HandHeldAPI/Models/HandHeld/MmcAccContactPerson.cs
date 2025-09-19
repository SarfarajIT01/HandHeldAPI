using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcAccContactPerson
{
    public string? AccCode { get; set; }

    public string? UnitCode { get; set; }

    public string? AccType { get; set; }

    public string? ContPer { get; set; }

    public string? ContDesg { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? Dom { get; set; }
}
