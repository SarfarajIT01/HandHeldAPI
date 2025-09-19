using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoSetupTax
{
    public int Id { get; set; }

    public string? TaxName { get; set; }

    public string? Message { get; set; }

    public double? DefaultValue { get; set; }

    public string? AutNo { get; set; }

    public string? RoundOff { get; set; }

    public DateTime? WefDate { get; set; }

    public double? Rvalue { get; set; }

    public bool? TaxBefore { get; set; }

    public string? OrderPre { get; set; }

    public sbyte? RateInc { get; set; }

    public sbyte? NoLt { get; set; }

    public double? NoLtamt { get; set; }

    public string? LicRegCap { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxType { get; set; }

    public string? NoLttrnAmt { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }

    public string? AccountId { get; set; }
}
