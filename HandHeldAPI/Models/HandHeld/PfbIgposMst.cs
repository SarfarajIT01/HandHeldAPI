using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbIgposMst
{
    public int GroupId { get; set; }

    public string? OutletId { get; set; }

    public string? Pos { get; set; }

    public string? OdrbilType { get; set; }

    public string? OdrbilSer { get; set; }

    public string? GrpCod { get; set; }

    public string? TreIpadd { get; set; }

    public string? BillHead { get; set; }

    public string? OrderHead { get; set; }

    public string? BillPrint { get; set; }

    public string? OrderPrint { get; set; }

    public string? OrderCode { get; set; }
}
