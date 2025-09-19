using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTallyemail
{
    public int Id { get; set; }

    public string? HfoHname { get; set; }

    public string? HfoTallyLink { get; set; }

    public string? HfoCompany { get; set; }

    public string? HfoFilePath { get; set; }

    public string? HfoEmail { get; set; }

    public string? HfoSubject { get; set; }

    public string? HfoMessage { get; set; }

    public string? HfoSmtpserver { get; set; }

    public int? HfoPort { get; set; }

    public string? HfoSendEmail { get; set; }

    public string? HfoPassword { get; set; }
}
