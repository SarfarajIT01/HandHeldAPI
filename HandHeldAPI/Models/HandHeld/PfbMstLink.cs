using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbMstLink
{
    public string? OutletId { get; set; }

    public string? RmsHmsLink { get; set; }

    public string? RmsCsatAu { get; set; }

    public string? RmsAuFile1 { get; set; }

    public string? RmsAuFile2 { get; set; }

    public string? RmsServer { get; set; }

    public string? RmsDb { get; set; }

    public string? RmsUser { get; set; }

    public string? RmsPass { get; set; }

    public string? RmsAcOn { get; set; }

    public string? RmsHmsBackEnd { get; set; }

    public string? RmsHmsSo { get; set; }

    public double? RmsRt { get; set; }

    public string? PropertyId { get; set; }
}
