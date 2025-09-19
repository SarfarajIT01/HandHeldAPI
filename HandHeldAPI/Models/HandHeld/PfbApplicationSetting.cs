using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbApplicationSetting
{
    public string? ToMail { get; set; }

    public string? FromMail { get; set; }

    public string? AttachPath { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }
}
