using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class Login
{
    public string TxtCompany { get; set; } = null!;

    public string? TxtLogin { get; set; }

    public string? Txtpwd { get; set; }
}
