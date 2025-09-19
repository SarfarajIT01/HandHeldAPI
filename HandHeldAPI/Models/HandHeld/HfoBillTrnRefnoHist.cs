using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillTrnRefnoHist
{
    public string? RoomNo { get; set; }

    public string? GuestCode { get; set; }

    public string? MasterGuest { get; set; }

    public string? MemberId { get; set; }

    public string? TrnType { get; set; }

    public string? TrnRefNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? TrnTime { get; set; }

    public string? TrnNarr { get; set; }

    public string? Grno { get; set; }

    public string? BillNo { get; set; }

    public string? OprId { get; set; }

    public string? GuestVisitor { get; set; }

    public string? ChgComp { get; set; }

    public string? DelTime { get; set; }

    public string? ActTime { get; set; }

    public string? ClrTime { get; set; }

    public string? ActEmp { get; set; }

    public string? ClrEmp { get; set; }

    public string? TrnStatus { get; set; }

    public string? TrnReason { get; set; }

    public bool? RmsFlag { get; set; }

    public string? OrgBillNo { get; set; }

    public string? PayMode { get; set; }

    public string? PayCurr { get; set; }

    public double? PayAmt { get; set; }

    public string? RetainBill { get; set; }

    public string? PkgFlag { get; set; }

    public string? LodFlag { get; set; }

    public string? TaxStru { get; set; }

    public string? ModCode { get; set; }

    public string? Mgrno { get; set; }

    public DateTime? ModDate { get; set; }

    public string? MrefNo { get; set; }

    public string? HotelCode { get; set; }

    public short? VisitNo { get; set; }

    public short? Mvisitno { get; set; }

    public short? HistNo { get; set; }

    public DateTime? ModDate1 { get; set; }

    public string? ModTime { get; set; }
}
