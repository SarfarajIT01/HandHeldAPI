using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoMst
{
    public int Id { get; set; }

    public DateTime? HmsRdate { get; set; }

    public DateTime? HmsStdate { get; set; }

    public string? HmsRbyTrnAmt { get; set; }

    public double? HmsRtrnAmt { get; set; }

    public string? HmsRbyNetAmt { get; set; }

    public double? HmsRnetAmt { get; set; }

    public string? HmsTcmsPath { get; set; }

    public int? HmsTimeDur { get; set; }

    public byte? HmsCPrintNo { get; set; }

    public byte? HmsGrPrintNo { get; set; }

    public byte? HmsBillPrintNo { get; set; }

    public byte? HmsTransPrintNo { get; set; }

    public byte? HmsReceiptPrintNo { get; set; }

    public string? HmsBillPrintNarration { get; set; }

    public bool? HmsDraftPrint { get; set; }

    public string? Country { get; set; }

    public string? HmsAutoDateChange { get; set; }

    public string? DefaultGtitle { get; set; }

    public string? DefaultGclass { get; set; }

    public string? DefaultCurrency { get; set; }

    public string? DefaultPayMode { get; set; }

    public string? DefaultNationality { get; set; }

    public string? DefaultBillSeries { get; set; }

    public bool? BackDate { get; set; }

    public bool? AutoPrint { get; set; }

    public string? FinLink { get; set; }

    public string? FinDataPath { get; set; }

    public string? FinGuestCheck { get; set; }

    public string? FinPostCheck { get; set; }

    public string? FinGuestGroup { get; set; }

    public string? FinCompGroup { get; set; }

    public string? FinDummyLedger { get; set; }

    public bool? Wcbill { get; set; }

    public bool? Mcbill { get; set; }

    public byte? LfbefC { get; set; }

    public byte? LfbefGr { get; set; }

    public byte? LfbefBill { get; set; }

    public byte? LfbefTrn { get; set; }

    public byte? LfbefRec { get; set; }

    public byte? LfaftC { get; set; }

    public byte? LfaftGr { get; set; }

    public byte? LfaftBill { get; set; }

    public byte? LfaftTrn { get; set; }

    public byte? LfaftRec { get; set; }

    public string? Rbino { get; set; }

    public short? HmsPrintType { get; set; }

    public short? HmsNoofLine { get; set; }

    public string? LodNarr { get; set; }

    public bool? HmsLineGap { get; set; }

    public string? HmsTcmsIpAdd { get; set; }

    public byte? RoomsRowNo { get; set; }

    public byte? RoomsColNo { get; set; }

    public double? OccBcolor { get; set; }

    public double? VacBcolor { get; set; }

    public double? BlkBcolor { get; set; }

    public double? OccFcolor { get; set; }

    public double? VacFcolor { get; set; }

    public double? BlkFcolor { get; set; }

    public string? DefaultMktSeg { get; set; }

    public short? Ccop { get; set; }

    public short? Grcop { get; set; }

    public short? Bcop { get; set; }

    public short? Tcop { get; set; }

    public short? Rcop { get; set; }

    public string? DayBookType { get; set; }

    public string? RateType { get; set; }

    public string? FinDataType { get; set; }

    public string? FinServerName { get; set; }

    public string? FinDatabaseName { get; set; }

    public bool? AllowRmsLink { get; set; }

    public bool? AllowTcmsLink { get; set; }

    public bool? AllowCrmLink { get; set; }

    public bool? AllowHrsLink { get; set; }

    public string? TcmsLinkDtype { get; set; }

    public bool? ClubLink { get; set; }

    public string? ClubSettlement { get; set; }

    public string? StwDesgMap { get; set; }

    public byte? ResPrintNo { get; set; }

    public byte? ResPlfaft { get; set; }

    public byte? ResPlfbef { get; set; }

    public byte? ResPnoCop { get; set; }

    public byte? RoomStsPrnNo { get; set; }

    public bool? HmsRdraftPrint { get; set; }

    public string? HmsGatePass { get; set; }

    public string? TrnPrintMsg { get; set; }

    public bool? CformDraftPrint { get; set; }

    public bool? GrDraftPrint { get; set; }

    public bool? BillDraftPrint { get; set; }

    public bool? TransDraftPrint { get; set; }

    public bool? ReceiptDraftPrint { get; set; }

    public bool? ReserveDraftPrint { get; set; }

    public bool? RoomDraftPrint { get; set; }

    public double? OutBcolor { get; set; }

    public double? OutFcolor { get; set; }

    public double? DirtyBcolor { get; set; }

    public double? DirtyFcolor { get; set; }

    public bool? InBillLessDiscRms { get; set; }

    public byte? DayBookPrnNo { get; set; }

    public bool? DayBookDraftPrint { get; set; }

    public string? DefaultCountry { get; set; }

    public string? DefaultMealPlan { get; set; }

    public short? CformDraftPrintType { get; set; }

    public short? GrDraftPrintType { get; set; }

    public short? BillDraftPrintType { get; set; }

    public short? TransDraftPrintType { get; set; }

    public short? ReceiptDraftPrintType { get; set; }

    public short? ReserveDraftPrintType { get; set; }

    public short? RoomDraftPrintType { get; set; }

    public short? DayBookDraftPrintType { get; set; }

    public string? DefaultTaxStru { get; set; }

    public byte? NightAuditPrnNo { get; set; }

    public bool? NightAuditDraftPrint { get; set; }

    public short? NightAuditDraftPrintType { get; set; }

    public string? AutoDateChangeTime { get; set; }

    public string? XmlfilePath { get; set; }

    public double? ExpBcolor { get; set; }

    public double? ExpFcolor { get; set; }

    public bool? AllowBnktLink { get; set; }

    public bool? AllowHltlink { get; set; }

    public bool? AllowPosrtllink { get; set; }

    public string? Hotelid { get; set; }

    public string? MsgCheckout { get; set; }

    public string? DefaultInsMaster { get; set; }

    public string? DefaultInsMember { get; set; }

    public string? HmsRbyTaxAmt { get; set; }

    public double? HmsRtaxAmt { get; set; }

    public byte? ResRecPrint { get; set; }

    public string? ResType { get; set; }

    public string? ResMode { get; set; }

    public string? ResStatus { get; set; }

    public byte[]? ReportLogo { get; set; }

    public string? Pbx { get; set; }

    public bool? BackTime { get; set; }

    public string? GrNo { get; set; }

    public short? ResRecDraftPrintType { get; set; }

    public bool? ResRecDraftPrint { get; set; }

    public byte? DayBookPrint { get; set; }

    public string? LinkWith { get; set; }

    public string? Font { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
