using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingAccRequiredDetail
{
    public int Id { get; set; }

    public string? ResNo { get; set; }

    public string? AccCode { get; set; }

    public int? Qty { get; set; }

    public int? AccRate { get; set; }

    public string? Remark { get; set; }

    public string? TaxStru { get; set; }

    public string? AccDesc { get; set; }

    public DateTime? AccDate { get; set; }

    public string? OutletCode { get; set; }
}
