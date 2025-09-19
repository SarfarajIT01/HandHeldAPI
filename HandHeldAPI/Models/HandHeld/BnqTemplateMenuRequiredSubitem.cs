using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqTemplateMenuRequiredSubitem
{
    public int Id { get; set; }

    public string? TempCod { get; set; }

    public string? SubItemCode { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }
}
