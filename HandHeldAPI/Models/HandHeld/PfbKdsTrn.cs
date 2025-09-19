using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models;

public partial class PfbKdsTrn
{
    public int Id { get; set; }
    public string? PosName { get; set; }

    public string? VNo { get; set; }

    public short? Qty { get; set; }

    public string? ItemName { get; set; }

    public float ItemColor { get; set; }

    public string? Sts { get; set; } 

    public float? Rate { get; set; }

    public string? ItemTime { get; set; } 

    public string? Remark { get; set; }
}
