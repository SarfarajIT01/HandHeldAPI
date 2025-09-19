using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbTicketingTimeslot
{
    public string? UnitId { get; set; }

    public string? TimeSlot { get; set; }

    public string? Status { get; set; }

    public string? Stime { get; set; }

    public int? MaxPax { get; set; }

    public int? MPax { get; set; }
}
