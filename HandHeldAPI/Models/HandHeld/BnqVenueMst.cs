using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqVenueMst
{
    public string VenueCode { get; set; } = null!;

    public string? VenueDesc { get; set; }

    public decimal? VenueCharge { get; set; }

    public decimal? GstCharge { get; set; }

    public string? SaleTaxNo { get; set; }

    public string? TaxStructure { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public int? MinPax { get; set; }

    public int? MaxPax { get; set; }

    public int? SeatPax { get; set; }

    public int? FloatingPax { get; set; }

    public string? InquiryNo { get; set; }

    public string? ResNo { get; set; }

    public string? KotNo { get; set; }

    public string? BillNo { get; set; }

    public string? PayNo { get; set; }

    public string? ReceiptNo { get; set; }

    public string? CstNo { get; set; }

    public string? RateLock { get; set; }

    public string? OutletCode { get; set; }
}
