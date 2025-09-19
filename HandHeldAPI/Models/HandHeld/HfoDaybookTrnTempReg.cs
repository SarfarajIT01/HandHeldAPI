using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoDaybookTrnTempReg
{
    public string? VouType { get; set; }

    public string? RefNo { get; set; }

    public string? SettleMode { get; set; }

    public DateTime? VouDate { get; set; }

    public string? Head { get; set; }

    public string? Narration { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? VouTime { get; set; }

    public string? OprId { get; set; }

    public string? TrnStatus { get; set; }

    public string? TrnReason { get; set; }

    public string? DbType { get; set; }

    public string? VouTime1 { get; set; }

    public string? RoomNo { get; set; }

    public string? GuestId { get; set; }

    public short? VisitNo { get; set; }

    public string? HotelCode { get; set; }
}
