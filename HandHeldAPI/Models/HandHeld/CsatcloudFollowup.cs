using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudFollowup
{
    public string FollowupId { get; set; } = null!;

    public string? FOnCode { get; set; }

    public string? FOnType { get; set; }

    public DateTime? Fdate { get; set; }

    public string? Fstatus { get; set; }

    public string? Employee { get; set; }

    public string? Comments { get; set; }

    public DateTime? NextFdate { get; set; }

    public string? NextFtime { get; set; }

    public string? NfcommType { get; set; }

    public string? Nexttodo { get; set; }

    public string? Phone { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? ModCode { get; set; }

    public string? Ftime { get; set; }

    public string? Fsub { get; set; }

    public string? Ftype { get; set; }

    public string? Fcode { get; set; }
}
