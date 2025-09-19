using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoBillHeaderFooter
{
    public int Id { get; set; }

    public string? BillId { get; set; }

    public string? Head1 { get; set; }

    public string? Head2 { get; set; }

    public string? Head3 { get; set; }

    public string? Head4 { get; set; }

    public string? Head5 { get; set; }

    public string? Footer1 { get; set; }

    public string? Footer2 { get; set; }

    public string? Footer3 { get; set; }

    public string? Footer4 { get; set; }

    public string? Footer5 { get; set; }
}
