using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoResMember
{
    public string? Sex { get; set; }

    public string? GuestId { get; set; }

    public string? ResNo { get; set; }

    public string? PassportNo { get; set; }

    public DateTime? PassIssDate { get; set; }

    public DateTime? PassExpDate { get; set; }

    public string? PlaceofIssue { get; set; }

    public string? AddinIndia1 { get; set; }

    public string? AddinIndia2 { get; set; }

    public string? ArrFrom { get; set; }

    public DateTime? DoainIndia { get; set; }

    public bool? EmpInIndia { get; set; }

    public string? VisaRegNo { get; set; }

    public DateTime? VisaIssuedate { get; set; }

    public string? Pcr { get; set; }

    public DateTime? VisaExpdate { get; set; }

    public string? PurposeofVisit { get; set; }

    public string? ProcTo { get; set; }

    public string? ProStayInIndia { get; set; }

    public string? MemberId { get; set; }

    public string? Nationality { get; set; }

    public string? GuestName { get; set; }

    public string? HotelCode { get; set; }
}
