
using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_LiveTableStatusController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_LiveTableStatusController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("{tableNo}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetLiveTableStatus(string tableNo)
        {
            try
            {
                var orders = await (from a in _context.PfbRkotSums
                                    join b in _context.PfbOutletposMsts on a.RsumPop equals b.PosCode
                                    where  a.RsumSts == "K" && a.RsumTbl == tableNo

                                    select new OrderItem
                                    {
                                        PosCode = a.RsumPop,
                                        PosName = b.PosDesc,
                                        TableNumber = a.RsumTbl,
                                        OrderType = a.RsumTyp,
                                        GuestCode = a.RsumGcd,
                                        GuestName = a.RsumGcdName,
                                        RsumRem = a.RsumRem,
                                        TotalAmount = (float?)a.RsumAmt,
                                        Covor = a.RsumCvr,
                                        RsumCsh = a.RsumCsh,
                                        StewardEmpId = a.RsumStw,
                                        OrderStatus = a.RsumSts,
                                        RsumTim = a.RsumTim,
                                        RsomKot = a.RsumKot
                                    }).ToListAsync();

                foreach (var ord in orders)
                {
                    // Get order details (items)
                    var orderItems = await _context.PfbRkotTrns
                        .Where(t => t.RkotNo == ord.RsomKot)
                        .ToListAsync();

                    var itemDetails = new List<CartItems>();

                    foreach (var itm in orderItems)
                    {
                        var menu = await _context.PfbMenuitemMasters
                            .Where(m => m.ItemCode == itm.RkotMnu)
                            .Select(m => m.Descript)
                            .FirstOrDefaultAsync();

                        var detail = new CartItems
                        {
                            RkotPop = itm.RkotPop,
                            RkotNo = itm.RkotNo,
                            RkotTyp = itm.RkotTyp,
                            ItemName = menu ?? "",
                            RkotMnu = itm.RkotMnu,
                            RkotDat = itm.RkotDat,
                            RkotRat = itm.RkotRat ?? 0,
                            Quantity = itm.RkotQty ?? 0,
                            RmnuRat = itm.RmnuRat ?? 0,
                            RkotTax = itm.RkotTax ?? 0,
                            RkotSno = itm.RkotSno ?? 0,
                            TaxType = itm.RkotTaxtyp,
                            RkotRem = itm.RkotRem,
                            RkotAddon = itm.RkotAddon,
                            RkotStax = itm.RkotStax,
                            RkotCombo = itm.RkotCombo,
                            RkotModifier = itm.RkotModifier,
                            GRPSubName = ""
                        };

                        // Load Add-ons
                        if (itm.RkotIsaddon == "y")
                        {
                            var addon = await (from add in _context.PfbRmnuAddons
                                               join trn in _context.PfbRkotTrns on add.RmnuAddonCod equals trn.RkotMnu
                                               where trn.RkotIsaddon == "y"
                                                     && trn.RkotNo == itm.RkotNo
                                               select new
                                               {
                                                   add.RmnuAddonCod,
                                                   add.RmnuAddonStd,
                                                   add.RmnuAddonRate
                                               }).FirstOrDefaultAsync();

                            if (addon != null)
                            {
                                detail.RmnuAddonCod = addon.RmnuAddonCod;
                                detail.RmnuAddonStd = addon.RmnuAddonStd;
                                detail.RmnuAddonRate = addon.RmnuAddonRate ?? 0;
                            }
                        }

                        // Load sub items
                        var subItems = await (from s in _context.PfbSubItemTrns
                                              join sub in _context.PfbSubItems on s.RkotSubitem equals sub.Id
                                              where s.RkotNo == itm.RkotNo && s.RkotSno == itm.RkotSno
                                              select new CartSubItems
                                              {
                                                  SubitemNo = s.RkotSubitem,
                                                  SubItemName = sub.SubName
                                              }).ToListAsync();

                        if (subItems.Any())
                        {
                            detail.SubItem = subItems;
                            detail.GRPSubName = subItems.FirstOrDefault()?.SubItemName ?? "";
                        }

                        // Load open item remarks
                        var remarks = await _context.PfbRkotMen
                            .Where(m => m.Kotno == itm.RkotNo && m.RkotSno == itm.RkotSno)
                            .Select(m => new RMS_RKOT_MAN2
                            {
                                CODE = m.Code,
                                DESCI = m.Desci,
                                DesORRem = m.DesOrrem
                            })
                            .ToListAsync();

                        if (remarks.Any())
                            detail.RKOT_MAN = remarks;

                        itemDetails.Add(detail);
                    }

                    ord.CartItem = itemDetails;
                }

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
