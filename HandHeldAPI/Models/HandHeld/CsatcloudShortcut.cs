using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudShortcut
{
    public string Modulecode { get; set; } = null!;

    public string? Usergroupcode { get; set; }

    public string? Mdiid { get; set; }

    public string? Filename { get; set; }

    public string? Serialno { get; set; }

    public string? Menuname { get; set; }
}
