using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqMenucardContainsSubitem
{
    public int Id { get; set; }

    public string? MenuCode { get; set; }

    public string? SubItemCode { get; set; }

    public string? ItemCode { get; set; }
}
