using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudDaybookhd
{
    public int Id { get; set; }

    public string? AccFlag { get; set; }

    public string? AccCode { get; set; }

    public string? AccDesc { get; set; }

    public string? Narration { get; set; }

    public string? Status { get; set; }

    public string? HsnCode { get; set; }
}
