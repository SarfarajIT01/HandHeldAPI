using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoLaundryDelivery
{
    public string? RefNo { get; set; }

    public string? ItemCode { get; set; }

    public short? DeliQty { get; set; }

    public string? SvrType { get; set; }

    public DateTime? DeliDate { get; set; }

    public string? DeliTime { get; set; }

    public string? Remark { get; set; }

    public string? DeliBy { get; set; }

    public string? DeliRefNo { get; set; }

    public string? BillFlag { get; set; }

    public string? RoomNo { get; set; }

    public string? HotelCode { get; set; }
}
