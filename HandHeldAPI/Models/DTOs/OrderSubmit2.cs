﻿using System.ComponentModel.DataAnnotations;

namespace HandHeldAPI.Models.DTOs
{
    public class OrderItem
    {
        public DateTime? Date { get; set; }
        public string? PosCode { get; set; }
        public string? PosName { get; set; }
        public string? OutletId { get; set; }
        public string? TableNumber { get; set; }
        public string? TableNo2 { get; set; }
        public float? TotalAmount { get; set; }
        public string? OrderNumber { get; set; }
        public string? OrderType { get; set; }
        public string? OrderStatus { get; set; }
        public string? GuestCode { get; set; }
        public string? GuestName { get; set; }
        public string? RsumRem { get; set; }
        public string? RSUM_BIL { get; set; }
        public short? Covor { get; set; }
        public string? RSUM_NAR { get; set; }
        public string? TotalItems { get; set; }
        public string? RsomKot { get; set; }
        public string? RSUM_CshC { get; set; }
        public string? RsumCsh { get; set; }
        public string? RSUM_EDT { get; set; }
        public float? RSUM_AMT { get; set; }
        public string? RSUM_SUBTBL { get; set; }
        public string? RsumTim { get; set; }
        public string? HH_DISC { get; set; }
        public string? RSUM_REMTYP { get; set; }
        public string? StewardEmpId { get; set; }
        public string? OrderRemark { get; set; }
        public string? TotalDisc { get; set; }
        public List<CartItems>? CartItem { get; set; }
    }

    public class CartItems
    {
        public string? RkotPop { get; set; }
        public string? RkotNo { get; set; }
        public string? RkotTyp { get; set; }
        public string? RkotMnu { get; set; }
        public string? ItemName { get; set; }
        public string? ItemCode { get; set; }
        public float? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? RkotTax { get; set; }
        public string? RkotStax { get; set; }
        public Int16? RkotSno { get; set; }
        public string? TaxType { get; set; }
        public DateTime? RkotDat { get; set; }
        public string? RKOT_TAXTYP { get; set; }
        public string? RkotRem { get; set; }
        public decimal? RkotRat { get; set; }
        public decimal? RmnuRat { get; set; }
        public float? RKOT_DISC { get; set; }
        public string? RkotAddon { get; set; }
        public string? TaxStruCode { get; set; }
        public string? RKOT_CVR { get; set; }
        public string? IsAddon { get; set; }
        public string? IsSubItem { get; set; }
        public string? RkotModifier { get; set; }
        public string? GRP_SUB { get; set; }
        public string? RKOT_WQTY { get; set; }
        public string? RKOT_TYPE { get; set; }
        public string? RkotCombo { get; set; }
        public string? COMBO_CODE { get; set; }
        public string? COMBO_FLAG { get; set; }
        public decimal? DiscountPer2 { get; set; }
        public decimal? Discount2 { get; set; }
        public string? OrderNo { get; set; }
        public string? RMNU_MODF { get; set; }
        public string? RmnuAddonCod { get; set; }
        public string? RmnuAddonStd { get; set; }
        public decimal? RmnuAddonRate { get; set; }
        public string? RMNU_M_COD { get; set; }
        public string? RMNU_M_STD { get; set; }
        public string? GRPSubName { get; set; }
        public string? UmeshSign { get; set; }
        public List<CartSubItems>? SubItem { get; set; }
        public List<RMS_RKOT_MAN2>? RKOT_MAN { get; set; }
    }

    public class CartSubItems
    {
        //[Required]
        public string? RKOT_POP { get; set; }
        public string? RKOT_NO { get; set; }
        public string? SubItemName { get; set; }
        public DateTime? RKOT_DAT { get; set; }
        public string? RKOT_MNU { get; set; }
        public Int16? RKOT_SNO { get; set; }
        public string? SubitemNo { get; set; }
        public Int16? SUB_SN { get; set; }
        public Int16? SUB_QTY { get; set; }
        public float? SubItemRates { get; set; }

    }

    public class RMS_RKOT_MAN2
    {
        public string? POS { get; set; }
        public DateTime? Kot_DATE { get; set; }
        public string? KOTNO { get; set; }
        public string? CODE { get; set; }
        public string? DESCI { get; set; }
        public string? DesORRem { get; set; }
        public Int16? RKOT_SNO { get; set; }
    }
}