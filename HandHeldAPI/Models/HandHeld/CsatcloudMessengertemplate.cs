using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMessengertemplate
{
    public string MtId { get; set; } = null!;

    public string? MtType { get; set; }

    public string? MtSubject { get; set; }

    public string? MtMessage { get; set; }

    public string? Smsemailtype { get; set; }

    public string? Status { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }

    public string? Document { get; set; }

    public string? Module { get; set; }

    public string? FontType { get; set; }

    public string? Fontcolor { get; set; }

    public string? FontSize { get; set; }

    public string? Editable { get; set; }
}
