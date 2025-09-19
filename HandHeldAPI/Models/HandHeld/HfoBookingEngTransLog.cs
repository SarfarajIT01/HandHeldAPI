using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBookingEngTransLog
{
    public string? OprId { get; set; }

    public string? TerIpAdd { get; set; }

    public DateTime? ChDate { get; set; }

    public string? ChTime { get; set; }

    public string? TransType { get; set; }

    public string? TransRefNo { get; set; }

    public string? OpType { get; set; }

    public string? Remarks { get; set; }

    public string? ProcessId { get; set; }

    public string? FormId { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }
}
