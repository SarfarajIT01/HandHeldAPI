using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCompanyunit
{
    public string Unitid { get; set; } = null!;

    public string? UnitName { get; set; }

    public string? Userintlgc { get; set; }

    public string? Addformat { get; set; }

    public string? Currency { get; set; }

    public string? Phnformat { get; set; }

    public string? PostalCode { get; set; }

    public string? PinZip { get; set; }

    public string? Taxcode { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public short? PhFormatwidth { get; set; }

    public short? PinFormatwidth { get; set; }

    public string? City { get; set; }

    public string? Area { get; set; }

    public string? Country { get; set; }

    public string? AddLabel1 { get; set; }

    public string? AddLabel2 { get; set; }

    public string? AddLabel3 { get; set; }
}
