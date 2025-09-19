using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoDailybudgt
{
    public int Id { get; set; }

    public string? RevSource { get; set; }

    public DateTime? Bdate { get; set; }

    public double? Bamt { get; set; }

    public string? RevSub { get; set; }

    public string? Remarks { get; set; }
}
