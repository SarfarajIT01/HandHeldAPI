using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbRbillSettMod
{
    public string? OutletId { get; set; }

    public string? RmsPos { get; set; }

    public DateTime? RmsDate { get; set; }

    public string? RmsBillNo { get; set; }

    public double? RmsAmount { get; set; }

    public string? RmsTime { get; set; }

    public string? RmsScode { get; set; }

    public string? RmsCcno { get; set; }

    public string? RmsIsTipAmt { get; set; }

    public string? RmsCashier { get; set; }

    public string? RmsRemark { get; set; }

    public string? RmsSettAdvAmt { get; set; }

    public string? RmsRefNo { get; set; }

    public DateTime? RmsSettDate { get; set; }

    public string? RmsSmode { get; set; }

    public string? RmsAuno { get; set; }

    public string? RmsVdate { get; set; }

    public string? RmsMname { get; set; }

    public string? RmsBillSer { get; set; }

    public string? GuestCode { get; set; }

    public string? AccountCode { get; set; }

    public string? RoomNo { get; set; }

    public string? CurCode { get; set; }

    public float? CurAmt { get; set; }
}
