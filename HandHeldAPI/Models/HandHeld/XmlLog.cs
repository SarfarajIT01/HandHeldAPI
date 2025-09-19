using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class XmlLog
{
    public string? XmlFile { get; set; }

    public string? ModCode { get; set; }

    public string? Tbl { get; set; }

    public string? Flag { get; set; }
}
