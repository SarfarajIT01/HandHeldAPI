using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudLostFound
{
    public string LostFoundId { get; set; } = null!;

    public DateTime? RefDate { get; set; }

    public string? RefTime { get; set; }

    public string? PName { get; set; }

    public string? PAdd1 { get; set; }

    public string? PAdd2 { get; set; }

    public string? Mobileno { get; set; }

    public string? Emailid { get; set; }

    public string? Phoneno { get; set; }

    public string? LostPlace { get; set; }

    public DateTime? LostDate { get; set; }

    public string? LostTeme { get; set; }

    public string? Event { get; set; }

    public string? Reportedto { get; set; }

    public string? Reportedby { get; set; }

    public string? Flagtype { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? Memcode { get; set; }

    public string? Memtype { get; set; }

    public string? Gn { get; set; }

    public string? AuthoriseType { get; set; }

    public string? DeliveredType { get; set; }
}
