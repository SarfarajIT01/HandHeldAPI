using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoPredefinedInstruction
{
    public string? Pdid { get; set; }

    public string? UsedIn { get; set; }

    public string? Instruction { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
