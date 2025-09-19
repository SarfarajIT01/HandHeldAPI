using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqFunctionTypeMst
{
    public string FuncTypeId { get; set; } = null!;

    public string? FuncDesc { get; set; }

    public string? FuncStatus { get; set; }

    public string? FuncRemark { get; set; }
}
