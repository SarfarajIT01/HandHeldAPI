using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillingSetup
{
    public int Id { get; set; }

    public string? BillSeries { get; set; }

    public string? BillDesc { get; set; }

    public string? BillCode { get; set; }

    public string? TrnType { get; set; }

    public bool? Bill1 { get; set; }

    public bool? Bill2 { get; set; }

    public bool? Bill3 { get; set; }

    public bool? Bill4 { get; set; }

    public bool? Bill5 { get; set; }

    public bool? Bill6 { get; set; }

    public string? Pmode1 { get; set; }

    public string? Pmode2 { get; set; }

    public string? Pmode3 { get; set; }

    public string? Pmode4 { get; set; }

    public string? Pmode5 { get; set; }

    public string? ModCode { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? BillT1 { get; set; }

    public string? BillT2 { get; set; }

    public string? BillT3 { get; set; }

    public string? BillT4 { get; set; }

    public string? BillT5 { get; set; }
}
