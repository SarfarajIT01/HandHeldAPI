using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqVenuresDetailsMod
{
    public string? VenueResNo { get; set; }

    public string? VenueCode { get; set; }

    public double? VenueRate { get; set; }

    public string? TaxCode { get; set; }

    public double? TaxAmount { get; set; }

    public string? VenueTimeSlot { get; set; }

    public DateTime? VenueResFdate { get; set; }

    public DateTime? VenueResToDate { get; set; }

    public DateTime? VenueResFtime { get; set; }

    public DateTime? VenueResToTime { get; set; }

    public string? ResStatus { get; set; }

    public string? VenueTemplate { get; set; }

    public short? EditNo { get; set; }

    public string? VenueResFtm { get; set; }

    public string? VenueResTtm { get; set; }

    public string? FpBill { get; set; }
}
