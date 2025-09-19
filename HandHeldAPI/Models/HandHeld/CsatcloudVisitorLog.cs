using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudVisitorLog
{
    public string? Slno { get; set; }

    public DateTime? VisitDate { get; set; }

    public string? TimeIn { get; set; }

    public string? TimeOut { get; set; }

    public string? PersonName { get; set; }

    public string? CompanyName { get; set; }

    public string? NoOfPerson { get; set; }

    public string? Purpose { get; set; }

    public string? VisitPurpose { get; set; }

    public string? VisitPerson { get; set; }

    public string? VisitContect { get; set; }

    public string? ClubCode { get; set; }

    public string? Modcode { get; set; }

    public string? MeetFlag { get; set; }

    public string? VisitorType { get; set; }

    public string? Visitorno { get; set; }
}
