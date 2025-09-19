using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CcaComCompany
{
    public int Id { get; set; }

    public string? CompCode { get; set; }

    public string? CompName { get; set; }

    public string? CompAdd1 { get; set; }

    public string? CompAdd2 { get; set; }

    public string? CompCity { get; set; }

    public string? CompPin { get; set; }

    public string? CompEmail { get; set; }

    public float? CompCl { get; set; }

    public string? CompPanNo { get; set; }

    public string? CompRemark { get; set; }

    public string? CompId { get; set; }

    public string? CompPhone1 { get; set; }

    public string? CompVno { get; set; }

    public string? CompLike { get; set; }

    public string? CompDislike { get; set; }

    public string? CompComment { get; set; }

    public string? CompPic { get; set; }

    public string? CompCat { get; set; }

    public DateTime? CompArrDate { get; set; }

    public DateTime? CompDepDate { get; set; }

    public string? CompSts { get; set; }

    public string? CompRoomNo { get; set; }

    public DateTime? CompInfoDate { get; set; }

    public DateTime? CompLoyaltyDate { get; set; }

    public string? State { get; set; }

    public string? GstinNo { get; set; }

    public string? BcstFlag { get; set; }

    public string? IsBuyer { get; set; }

    public string? IsCompany { get; set; }

    public string? IsSupplier { get; set; }

    public string? IsTravelAgent { get; set; }

    public string? IsServiceProvider { get; set; }
}
