using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class PfbMenuitemMaster
{
    public string ItemCode { get; set; } = null!;

    public string? Descript { get; set; }

    public string? AliasName { get; set; }

    public string? ShortCode { get; set; }

    public string? ItemGroup { get; set; }

    public string? MenuCat { get; set; }

    public string? TouchCat { get; set; }

    public string? KitchenDept { get; set; }

    public string? Uom { get; set; }

    public decimal? CostPur { get; set; }

    public float? PrepTime { get; set; }

    public string? SalesPromotion { get; set; }

    public string? DiscAllow { get; set; }

    public string? AboutItem { get; set; }

    public float? MinQty { get; set; }

    public float? MaxQty { get; set; }

    public float? MinRate { get; set; }

    public float? MaxRate { get; set; }

    public string? SubItem { get; set; }

    public string? OpenMenu { get; set; }

    public string? QtySubUnit { get; set; }

    public string? ComboMeal { get; set; }

    public string? PosBalance { get; set; }

    public string? Picture { get; set; }

    public double? Color { get; set; }

    public short? PositionRow { get; set; }

    public short? PositionCol { get; set; }

    public string? FontName { get; set; }

    public short? FontSize { get; set; }

    public string? Status { get; set; }

    public string? RmnuFo { get; set; }

    public string? BarCode { get; set; }

    public string? EanCode { get; set; }

    public string? Brand { get; set; }

    public string? CostCenter { get; set; }

    public string? RmnuStax { get; set; }

    public string? RmnuTax { get; set; }

    public string? WpfColor { get; set; }

    public byte[]? WebImage { get; set; }

    public string? RmnuTpict { get; set; }

    public string? MenuDesc { get; set; }

    public string? Supplier { get; set; }

    public string? AboutMenu { get; set; }

    public string? VegNonveg { get; set; }

    public string? Calories { get; set; }

    public string? HsnCode { get; set; }

    public string? RmnuModifier { get; set; }

    public string? RmnuAddon { get; set; }

    public string? TouchFname { get; set; }

    public string? RmnuMt { get; set; }

    public string? ActKds { get; set; }

    public string? RateThirdParty { get; set; }

    public string? CommonAddon { get; set; }

    public string? GrpSubitem { get; set; }
}
