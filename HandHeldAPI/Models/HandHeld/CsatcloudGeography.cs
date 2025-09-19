using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudGeography
{
    public int Id { get; set; }

    public string? LuscnFlag { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? Nationality { get; set; }

    public string? Language1 { get; set; }

    public string? Continents { get; set; }

    public string? Currency { get; set; }

    public string? LuscnCode { get; set; }
}
