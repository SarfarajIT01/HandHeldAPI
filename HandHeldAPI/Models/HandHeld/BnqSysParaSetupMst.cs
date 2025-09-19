using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqSysParaSetupMst
{
    public int Id { get; set; }

    public bool? NoGenVenueOrSysPar { get; set; }

    public string? EnquiryNo { get; set; }

    public string? ReservationNo { get; set; }

    public string? BillNo { get; set; }

    public string? KotNo { get; set; }

    public string? PaymentNo { get; set; }

    public string? ReceiptNo { get; set; }

    public string? OrderNo { get; set; }

    public double? RoundTax { get; set; }

    public string? RoundTaxType { get; set; }

    public double? RoundFinalBill { get; set; }

    public string? RoundFinalBillType { get; set; }

    public string? SettelmentCode { get; set; }

    public string? MesServiceCharge { get; set; }

    public string? MesSalesTax { get; set; }

    public string? MesExpTax { get; set; }

    public string? MesOtherTax { get; set; }

    public string? MesDiscount1 { get; set; }

    public string? MesDiscount2 { get; set; }

    public string? ServiceCharge1 { get; set; }

    public string? ServiceCharge2 { get; set; }

    public string? ServiceCharge3 { get; set; }

    public string? SalesTax { get; set; }

    public string? ExpTax { get; set; }

    public string? OthTax { get; set; }

    public int? RepFpFmt { get; set; }

    public DateTime? CurrDate { get; set; }

    public int? RepBillFmt { get; set; }

    public short? LfBefore { get; set; }

    public short? LfAfter { get; set; }

    public string? BnqGenGstCode { get; set; }

    public string? BnqGstRefNo { get; set; }

    public string? BnqResHeader { get; set; }

    public string? BnqBillHeader { get; set; }

    public string? SettNo { get; set; }

    public string? CompanyRefNo { get; set; }

    public string? CompanyRefType { get; set; }

    public string? CompanyUnit { get; set; }

    public string? BnqManualRec { get; set; }

    public string? RepRecFmt { get; set; }

    public string? BnqMultiDate { get; set; }

    public string? BnqBillFooter { get; set; }

    public string? BnqViewStatus { get; set; }

    public DateTime? BnqStDate { get; set; }

    public string? BnqPaxVal { get; set; }

    public DateTime? BnqStTime { get; set; }

    public DateTime? BnqEtime { get; set; }

    public string? BnqStTm { get; set; }

    public string? BnqEtm { get; set; }

    public short? BnqSlot { get; set; }

    public string? BnqEmail { get; set; }

    public string? BnqUserId { get; set; }

    public string? BnqPassword { get; set; }

    public string? BnqMenu { get; set; }

    public string? SerCode { get; set; }

    public string? DayPayNo { get; set; }

    public string? DayRecNo { get; set; }

    public string? BnqCost { get; set; }

    public int? RepAgreeFmt { get; set; }

    public string? ReportLogo { get; set; }

    public string? GridName { get; set; }

    public string? ChkRunDate { get; set; }

    public string? ChkSett { get; set; }

    public string? PaxTax { get; set; }

    public string? VenueTax { get; set; }

    public string? EnqNo { get; set; }

    public string? EnqHeader { get; set; }

    public string? EnqFooter { get; set; }

    public string? OutletCode { get; set; }
}
