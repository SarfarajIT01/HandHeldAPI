using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models;

public partial class PfbSubItemTrn
{
    public int Id { get; set; }
    public string? RkotPop { get; set; }

    public string? RkotNo { get; set; } = null!;

    public DateTime? RkotDat { get; set; }

    public string? RkotMnu { get; set; }

    public short? RkotSno { get; set; }

    public string? RkotSubitem { get; set; }

    public short? SubSn { get; set; }

    public string? Flag { get; set; }
}
