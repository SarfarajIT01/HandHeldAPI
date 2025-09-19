using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudDepartmenet
{
    public string DepCode { get; set; } = null!;

    public string? DeptName { get; set; }

    public string Status { get; set; } = null!;
}
