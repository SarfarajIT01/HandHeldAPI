using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCurrency
{
    public int Id { get; set; }

    public string? CurCode { get; set; }

    public string? CurDesc { get; set; }

    public string? PartDesc { get; set; }

    public string? CurSymbol { get; set; }

    public string? CurDplace { get; set; }

    public string? CurrencyStatus { get; set; }

    public string? DplaceSymbol { get; set; }

    public string? AmountSymbol { get; set; }

    public string? AmountMillions { get; set; }

    public string? SuffixAmount { get; set; }

    public string? DefaultCurrency { get; set; }

    public string? Country { get; set; }
}
