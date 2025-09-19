using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGuestFamily
{
    public string GuestId { get; set; } = null!;

    public string? Relation { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }
}
