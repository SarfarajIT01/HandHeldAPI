using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResInstruction
{
    public string? Pdid { get; set; }

    public string? UsedIn { get; set; }

    public string? Instruction { get; set; }

    public string? Remark { get; set; }

    public string? ResNo { get; set; }

    public string? Sel { get; set; }

    public string? Flag { get; set; }

    public string? HotelCode { get; set; }
}
