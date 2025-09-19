using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoTaxTemp
{
    public DateTime? TrnDate { get; set; }

    public double? TrnRent { get; set; }

    public double? LTax { get; set; }

    public double? TrnFood { get; set; }

    public double? FdTax { get; set; }

    public double? FdNtax { get; set; }

    public double? RoomDisc { get; set; }

    public double? FdDisc { get; set; }

    public string? HotelCode { get; set; }

    public string? ModCode { get; set; }
}
