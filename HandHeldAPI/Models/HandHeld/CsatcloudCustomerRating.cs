using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudCustomerRating
{
    public short? Afrom { get; set; }

    public short? Ato { get; set; }

    public string Alabel { get; set; } = null!;
}
