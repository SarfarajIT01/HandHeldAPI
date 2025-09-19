using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoSetupTrnhead
{
    public int Id { get; set; }

    public string? TrnCode { get; set; }

    public string? TrnSubCode { get; set; }

    public string? Pos { get; set; }

    public string? TrnSubHeadDesc { get; set; }

    public string? Taxable { get; set; }

    public double? Taxes { get; set; }

    public double? Rate { get; set; }

    public double? Rate1 { get; set; }

    public double? Rate2 { get; set; }

    public double? Rate3 { get; set; }

    public double? Rmod { get; set; }

    public double? OpenMenu { get; set; }

    public string? TaxStru { get; set; }

    public string? Scode { get; set; }

    public bool? SubUnit { get; set; }

    public string? PbxItem { get; set; }

    public double? UnitCost { get; set; }

    public string? Status { get; set; }

    public string? AccountId { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }
}
