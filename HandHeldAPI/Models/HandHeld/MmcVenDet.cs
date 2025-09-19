using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class MmcVenDet
{
    public string? VenCode { get; set; }

    public string? VenQtyRating { get; set; }

    public string? VenConfidenceRating { get; set; }

    public string? VenDelRating { get; set; }

    public string? VenPriceRating { get; set; }
}
