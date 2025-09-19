using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoInguestRoom
{
    public string? GuestId { get; set; }

    public DateTime? ArrDate { get; set; }

    public string? RoomNo { get; set; }

    public string? Title { get; set; }

    public string? GmembId { get; set; }

    public string? GuestName { get; set; }

    public short? Adult { get; set; }

    public short? Minor { get; set; }

    public short? Infant { get; set; }

    public double? Tarrif { get; set; }

    public string? ArrTime { get; set; }

    public DateTime? DepDate { get; set; }

    public string? DepTime { get; set; }

    public string? Grno { get; set; }

    public double? Gtarrif { get; set; }

    public double? OldGtarrif { get; set; }

    public string? ChargeType { get; set; }

    public string? SurChg { get; set; }

    public string? Ltax { get; set; }

    public string? HouseGuest { get; set; }

    public double? ExGRent { get; set; }

    public double? MinGRent { get; set; }

    public string? TaxStru { get; set; }

    public double? InfGRent { get; set; }

    public string? MealPlan { get; set; }

    public string? FdtaxStru { get; set; }

    public string? PackPlan { get; set; }

    public short? PkgDayNo { get; set; }

    public string? ChkOutRemark { get; set; }

    public string? CheckInType { get; set; }

    public string? TrnTaxStru { get; set; }

    public string? TransferReason { get; set; }

    public string? UndoReason { get; set; }

    public string? TrnsUserId { get; set; }

    public string? MasterId { get; set; }

    public string? Mgrno { get; set; }

    public short? Csno { get; set; }

    public string? Nationalities { get; set; }

    public string? Droptime { get; set; }

    public string? Dropmode { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public short? Mvisitno { get; set; }

    public short? Visitno { get; set; }

    public string? HfoGacid { get; set; }
}
