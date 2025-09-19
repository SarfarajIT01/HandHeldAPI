using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqTemplateAccRequiredDetail
{
    public int Id { get; set; }

    public string? TempCod { get; set; }

    public string? AccCode { get; set; }

    public int? Qty { get; set; }

    public int? AccRate { get; set; }

    public string? Remark { get; set; }

    public string? TaxStru { get; set; }

    public string? AccDesc { get; set; }
}
