using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqItemSubitem
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? SubItemCode { get; set; }
}
