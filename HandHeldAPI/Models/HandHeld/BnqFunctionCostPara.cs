using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class BnqFunctionCostPara
{
    public string? FunctionCode { get; set; }

    public string? Code { get; set; }

    public string? CostHead { get; set; }

    public double? Amount { get; set; }

    public string? Remarks { get; set; }
}
