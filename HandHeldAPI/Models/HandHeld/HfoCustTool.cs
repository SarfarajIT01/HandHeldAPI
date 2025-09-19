using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoCustTool
{
    public int Id { get; set; }

    public string? ToolCaption { get; set; }

    public string? ToolBackcolor { get; set; }

    public string? ToolFont { get; set; }

    public string? ToolPicture { get; set; }

    public string? Menuname { get; set; }

    public string? MenuCaption { get; set; }

    public string? ModCode { get; set; }

    public int? SNo { get; set; }
}
