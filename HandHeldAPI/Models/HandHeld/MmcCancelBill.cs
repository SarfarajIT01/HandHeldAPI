using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcCancelBill
{
    public string? OutletId { get; set; }

    public string? LocCode { get; set; }

    public string? BillType { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public string? AccCode { get; set; }

    public string? EmpCode { get; set; }

    public string? OpId { get; set; }

    public DateTime? CDate { get; set; }

    public DateTime? CTime { get; set; }
}
