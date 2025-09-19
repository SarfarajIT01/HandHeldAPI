using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudRatingmst
{
    public string RatingCode { get; set; } = null!;

    public string? RatingDesc { get; set; }

    public string? RatingFlag { get; set; }

    public string? RatingRank { get; set; }

    public string? Remark { get; set; }
}
