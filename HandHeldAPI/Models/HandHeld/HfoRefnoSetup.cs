using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRefnoSetup
{
    public int Id { get; set; }

    public string? Grno { get; set; }

    public string? CformNo { get; set; }

    public string? BillNo { get; set; }

    public string? ReceiptNo { get; set; }

    public string? PaymentNo { get; set; }

    public string? CityLedgerNo { get; set; }

    public string? CouponNo { get; set; }

    public bool? CouponActive { get; set; }

    public bool? CouponBilling { get; set; }

    public string? CompanyRefType { get; set; }

    public string? CompanyRefNo { get; set; }

    public bool? CompanyUnit { get; set; }

    public string? AgentRefType { get; set; }

    public string? AgentRefNo { get; set; }

    public bool? AgentUnit { get; set; }

    public string? Ecno { get; set; }

    public string? PkgTrnNo { get; set; }

    public string? CashMemoNo { get; set; }

    public string? DbrecNo { get; set; }

    public string? DbpayNo { get; set; }

    public bool? ManDbrecNo { get; set; }

    public bool? ManDbpayNo { get; set; }

    public bool? ManRecNo { get; set; }

    public string? SupplierRefType { get; set; }

    public string? SupplierRefNo { get; set; }

    public string? BillPrefixNo { get; set; }

    public string? SecurityRefundNo { get; set; }

    public string? SecurityDepositNo { get; set; }

    public bool? SupplierUnit { get; set; }

    public string? Coexitno { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? HfoGacid { get; set; }
}
