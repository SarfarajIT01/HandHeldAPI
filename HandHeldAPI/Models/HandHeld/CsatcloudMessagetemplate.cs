using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudMessagetemplate
{
    public string ModCode { get; set; } = null!;

    public string TrnCode { get; set; } = null!;

    public string TempId { get; set; } = null!;

    public string? Length { get; set; }

    public string? Message { get; set; }

    public string? TrnDesc { get; set; }

    public string? Status { get; set; }
}
