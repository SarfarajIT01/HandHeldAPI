using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudHelponline
{
    public string? ModCode { get; set; }

    public string? FormId { get; set; }

    public string? FieldId { get; set; }

    public string? About { get; set; }

    public byte[]? Image { get; set; }
}
