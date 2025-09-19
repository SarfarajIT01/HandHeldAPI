using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMessengertransaction
{
    public string MtrnId { get; set; } = null!;

    public string? FrmEmailsms { get; set; }

    public string? ToEmailsms { get; set; }

    public string? MtrnSubject { get; set; }

    public string? MtrnMessage { get; set; }

    public string? IpAdd { get; set; }

    public DateTime? MtrnDate { get; set; }

    public string? MtrnTime { get; set; }

    public string? Smsemailtype { get; set; }

    public string? MtrnType { get; set; }

    public string? Attachment { get; set; }

    public string? OnOffline { get; set; }

    public string? UserId { get; set; }

    public string? TempId { get; set; }
}
