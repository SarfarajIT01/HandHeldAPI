using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoGuestMst
{
    public int Id { get; set; }

    public string? GuestCode { get; set; }

    public string? GuestTitle { get; set; }

    public string? GuestName { get; set; }

    public string? GuestClass { get; set; }

    public string? GuestSex { get; set; }

    public DateTime? GuestDob { get; set; }

    public DateTime? GuestDom { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Nationality { get; set; }

    public string? SpouseName { get; set; }

    public DateTime? SpouseDob { get; set; }

    public string? CompCode { get; set; }

    public string? CompUnit { get; set; }

    public string? AgentCode { get; set; }

    public string? GuestFlag { get; set; }

    public string? GuestEmail1 { get; set; }

    public string? GuestEmail2 { get; set; }

    public string? Glname { get; set; }

    public string? Gfname { get; set; }

    public string? Gmname { get; set; }

    public string? State { get; set; }

    public string? Grno { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public short? VisitNo { get; set; }
}
