using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CcaComGuest
{
    public int Id { get; set; }

    public string? GuestCode { get; set; }

    public string? GName { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public DateTime? GuestDob { get; set; }

    public DateTime? MDay { get; set; }

    public string? City { get; set; }

    public string? Pin { get; set; }

    public string? Email { get; set; }

    public float? CreditLimit { get; set; }

    public string? PanNo { get; set; }

    public string? CelluNo { get; set; }

    public string? GRem { get; set; }

    public DateTime? LastVisit { get; set; }

    public DateTime? DisValidDate { get; set; }

    public string? SpouseName { get; set; }

    public string? GProfession { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    public string? GLike { get; set; }

    public string? GDislike { get; set; }

    public double? EarnPoint { get; set; }

    public double? RedimPoint { get; set; }

    public DateTime? SpDob { get; set; }

    public string? Firstname { get; set; }

    public string? Middlename { get; set; }

    public string? Company { get; set; }

    public string? Designation { get; set; }

    public string? Comment { get; set; }

    public string? PicGuest { get; set; }

    public string? Ctype { get; set; }

    public string? Gtitle { get; set; }

    public string? Gcategory { get; set; }

    public string? GSex { get; set; }

    public string? GEdu { get; set; }

    public short? GFsize { get; set; }

    public string? GcmFlag { get; set; }

    public bool? IsGuest { get; set; }

    public bool? IsClient { get; set; }

    public bool? IsMember { get; set; }
}
