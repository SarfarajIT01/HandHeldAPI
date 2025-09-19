using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbGuestCommentItemwise
{
    public string? OutletId { get; set; }

    public string? GuestCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Comment { get; set; }

    public DateTime? RmsDate { get; set; }
}
