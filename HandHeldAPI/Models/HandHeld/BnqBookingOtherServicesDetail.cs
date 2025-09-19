using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqBookingOtherServicesDetail
{
    public int Id { get; set; }

    public string? ResNo { get; set; }

    public string? OtherSerCode { get; set; }

    public int? ServQty { get; set; }

    public int? ServRate { get; set; }

    public string? TaxStru { get; set; }

    public string? Remark { get; set; }

    public string? OtherDesc { get; set; }

    public string? OutletCode { get; set; }
}
