using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqMenucardContainsGroup
{
    public int Id { get; set; }

    public string? MenuCode { get; set; }

    public string? GroupCode { get; set; }
}
