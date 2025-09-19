using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqTemplateOpenItem
{
    public int Id { get; set; }

    public string? TempCod { get; set; }

    public string? ItemCode { get; set; }

    public int? ItemRate { get; set; }

    public int? Qty { get; set; }

    public string? TaxStru { get; set; }

    public string? ItemDesc { get; set; }
}
