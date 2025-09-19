using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoPkgBreakup
{
    public string? PkgCode { get; set; }

    public string? TrnCode { get; set; }

    public byte? DayNo { get; set; }

    public string? TrnSubCode { get; set; }

    public decimal? TrnAmount { get; set; }

    public byte? OrderNo { get; set; }

    public string? RoomType { get; set; }

    public short? AllowPax { get; set; }

    public double? ExtraPax { get; set; }

    public string? Remark { get; set; }

    public string? TaxType { get; set; }

    public string? TaxStru { get; set; }

    public decimal? ETrnAmount { get; set; }

    public decimal? MTrnAmount { get; set; }

    public decimal? ITrnAmount { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
