using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoPkgMst
{
    public int Id { get; set; }

    public string? PkgName { get; set; }

    public string? PkgCode { get; set; }

    public string? RoomType { get; set; }

    public string? MealPlan { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public short? Nights { get; set; }

    public short? NoDays { get; set; }

    public string? Breakfast { get; set; }

    public string? Lunch { get; set; }

    public string? Dinner { get; set; }

    public short? Adult { get; set; }

    public short? Minor { get; set; }

    public double? PkgRate { get; set; }

    public string? PkgCurr { get; set; }

    public string? Remark { get; set; }

    public double? Fsa { get; set; }

    public double? ExtraTariff { get; set; }

    public string? BillCommemnt { get; set; }

    public string? ArrivComment { get; set; }

    public string? ComplComment { get; set; }

    public string? PackageType { get; set; }

    public short? Infant { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? SamePkgpostForExtraDay { get; set; }
}
