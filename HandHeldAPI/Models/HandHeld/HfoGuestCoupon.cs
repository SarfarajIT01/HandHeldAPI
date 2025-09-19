using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoGuestCoupon
{
    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? BillNo { get; set; }

    public string? CouponNo { get; set; }

    public DateTime? CouponDate { get; set; }

    public string? TrnType { get; set; }

    public double? CouponValue { get; set; }

    public string? Remark { get; set; }

    public string? RefNo { get; set; }

    public double? Amount { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
