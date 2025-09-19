using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudImagegallary
{
    public string? ModuleCode { get; set; }

    public string? MasterType { get; set; }

    public string? MasterCode { get; set; }

    public string? ImageId { get; set; }

    public string? AboutImage { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte[]? MasterImage { get; set; }
}
