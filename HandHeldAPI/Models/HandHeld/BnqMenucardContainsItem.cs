using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqMenucardContainsItem
{
    public int Id { get; set; }

    public string? MenuCode { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }
}
