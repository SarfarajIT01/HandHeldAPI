using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudUserMst
{
    public string? UserId { get; set; }

    public string? UserType { get; set; }

    public string? UserPwd { get; set; }

    public DateTime? UserCreation { get; set; }

    public DateTime? UserExpiry { get; set; }

    public string? UserFirstName { get; set; }

    public string? UserLastName { get; set; }

    public string? UserCompany { get; set; }

    public string? UserTheme { get; set; }

    public short? UserGroup { get; set; }
}
