using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCompanyuserid
{
    public string UserId { get; set; } = null!;

    public string? UserType { get; set; }

    public string? UserPwd { get; set; }

    public DateTime? UserCreation { get; set; }

    public DateTime? UserExpiry { get; set; }

    public string? UserFirstName { get; set; }

    public short? UserGroup { get; set; }

    public string? MaxUnit { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public string? Mobileno { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public string? DefaultUnit { get; set; }

    public string? UserImage { get; set; }

    // i implemented this property to match the original code structure
    [NotMapped]
    public string? Token { get; set; }
}
