using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMessengerConfig
{
    public string? ModuleName { get; set; }

    public string? MsgType { get; set; }

    public string? Email { get; set; }

    public string? Sms { get; set; }

    public string? EmailTemp { get; set; }

    public string? Smstemp { get; set; }
}
