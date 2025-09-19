using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbGuestCc
{
    public string? OutletId { get; set; }

    public string? GuestId { get; set; }

    public string? CcName { get; set; }

    public string? CcNo { get; set; }

    public DateTime? CcExpDate { get; set; }
}
