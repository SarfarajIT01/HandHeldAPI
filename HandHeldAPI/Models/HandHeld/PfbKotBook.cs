using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbKotBook
{
    public string? Pos { get; set; }

    public string? Kottyp { get; set; }

    public string? Bookissue { get; set; }

    public string? Stno { get; set; }

    public string? Edno { get; set; }

    public DateTime? IssueFrom { get; set; }

    public DateTime? IssueTo { get; set; }
}
