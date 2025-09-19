using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqMaxQtySpecDetail
{
    public int Id { get; set; }

    public string? SelectionCode { get; set; }

    public string? MenuCode { get; set; }

    public string? Item { get; set; }

    public short? Defined { get; set; }

    public short? Allowed { get; set; }
}
