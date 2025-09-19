using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbCategoryMaster
{
    public string Code { get; set; } = null!;

    public string? CuFlag { get; set; }

    public string? Description { get; set; }

    public string? ShortName { get; set; }

    public string? GroupName { get; set; }

    public string? Kitchen { get; set; }

    public string? OrderNoSave { get; set; }

    public string? Remarks { get; set; }

    public string? MinNoItemSave { get; set; }

    public string? ParentCategory { get; set; }

    public string? PreparationTime { get; set; }

    public string? Status { get; set; }

    public string? PosBalance { get; set; }
}
