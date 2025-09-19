using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoLaundryTrn
{
    public string? RefNo { get; set; }

    public string? ItemName { get; set; }

    public short? TrnQty { get; set; }

    public string? SvrType { get; set; }

    public DateTime? DeliDate { get; set; }

    public string? DeliTime { get; set; }

    public string? Remark { get; set; }

    public short? HouseCount { get; set; }

    public short? GuestCount { get; set; }

    public string? ItemCode { get; set; }

    public double? TrnRate { get; set; }

    public string? TaxStru { get; set; }

    public string? TableNo { get; set; }

    public double? Disc { get; set; }

    public string? HotelCode { get; set; }
}
