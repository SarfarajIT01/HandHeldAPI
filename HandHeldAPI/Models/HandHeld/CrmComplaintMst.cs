using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CrmComplaintMst
{
    public string? Code { get; set; }

    public string? CplNo { get; set; }

    public DateTime? CplDate { get; set; }

    public string? CplGroup { get; set; }

    public string? Location { get; set; }

    public string? CplRemarks { get; set; }

    public string? FollowActive { get; set; }

    public string? FlagGc { get; set; }

    public string? ModuleCode { get; set; }

    public string? Dept { get; set; }

    public string? Subject { get; set; }
}
