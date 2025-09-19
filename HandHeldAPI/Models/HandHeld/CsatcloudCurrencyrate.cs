using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCurrencyrate
{
    public string CurCode { get; set; } = null!;

    public string? CurGroupCode { get; set; }

    public DateTime? ValidDate { get; set; }

    public string FromCur { get; set; } = null!;

    public string ToCur { get; set; } = null!;

    public decimal? Ratio1 { get; set; }

    public decimal? Ratio2 { get; set; }
}
