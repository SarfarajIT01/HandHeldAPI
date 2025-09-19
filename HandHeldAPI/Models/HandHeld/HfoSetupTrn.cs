using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoSetupTrn
{
    public int Id { get; set; }

    public string? TrnTypeCode { get; set; }

    public string? Name { get; set; }

    public string? TrnNarr { get; set; }

    public string? Shortname { get; set; }

    public string? TrnSerOn { get; set; }

    public string? TrnSerNo { get; set; }

    public bool? Stax { get; set; }

    public bool? Ltax { get; set; }

    public bool? SurTax { get; set; }

    public bool? Tax1 { get; set; }

    public bool? Tax2 { get; set; }

    public bool? Vstax { get; set; }

    public bool? Vltax { get; set; }

    public double? VsurTax { get; set; }

    public bool? Vtax1 { get; set; }

    public bool? Vtax2 { get; set; }

    public bool? Activate { get; set; }

    public string? GStru { get; set; }

    public string? VStru { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
