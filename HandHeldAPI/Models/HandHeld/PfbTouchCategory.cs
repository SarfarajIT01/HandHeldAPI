using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbTouchCategory
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? ParentLevel { get; set; }

    public string? GroupName { get; set; }

    public string? Status { get; set; }

    public string? Picture { get; set; }

    public double? Color { get; set; }

    public string? Font { get; set; }

    public string? FontSize { get; set; }

    public double? BtnHeight { get; set; }

    public double? BtnWidth { get; set; }

    public string? WpfColor { get; set; }

    public byte[]? WebImage { get; set; }

    public string? CatTPict { get; set; }

    public double? CatRow { get; set; }

    public double? CatCol { get; set; }

    public string? CuKitchen { get; set; }
}
