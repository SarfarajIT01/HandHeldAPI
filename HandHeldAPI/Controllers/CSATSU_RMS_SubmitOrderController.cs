using HandHeldAPI.Data;
using HandHeldAPI.Models;
using HandHeldAPI.Models.DTOs;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSATSU_RMS_SubmitOrderController : ControllerBase
    {
        private static readonly object Lock = new object();
        private readonly HandHeldDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CSATSU_RMS_SubmitOrderController> _logger;
        short SearialNo = 1;

        public CSATSU_RMS_SubmitOrderController(
            HandHeldDbContext context,
            IConfiguration configuration,
            ILogger<CSATSU_RMS_SubmitOrderController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderItem order)
         {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Remove the lock and use async properly
            try
            {
                var result = await ProcessOrder(order);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing order");
                return StatusCode(500, ex.Message);
            }
        }

        private async Task<string> ProcessOrder(OrderItem order)
        {
            // Get outletId and userId from headers
            if (!Request.Headers.TryGetValue("X-OutletId", out var outletIdHeader))
            {
                return "Missing outletId header";
            }

            if (!Request.Headers.TryGetValue("X-UserId", out var userIdHeader))
            {
                return "Missing userId header";
            }

            string outletId = outletIdHeader;
            string userId = userIdHeader;

            // Process order logic
            var orderResult = await ProcessOrderInternal(order, outletId, userId);
            return orderResult;
        }

        private async Task<string> ProcessOrderInternal(OrderItem order, string outletId, string userId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Log start of transaction
                await LogTransactionStart(outletId, userId);
                
                // Process guest information
                //await ProcessGuestInformation(order);

                // Process order items
                var (orderNos, usedGroup) = await ProcessOrderItems(order, outletId);
               
                // Insert order details
                await InsertOrderDetails(order, orderNos, usedGroup, outletId, userId);
                
                // Update table status
                await UpdateTableStatus(order, outletId);

                // Log end of transaction
                await LogTransactionEnd(outletId, userId, order.OrderNumber);

                // Insert into print queue
                //await InsertPrintQueueEntries(usedGroup, order.POS);


                await transaction.CommitAsync();
                return "Insert Successfully";
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                _logger.LogError(ex, "Error processing order");
                throw;
            }
        }

        private async Task ProcessGuestInformation(OrderItem order)
        {
            if (string.IsNullOrEmpty(order.guest_name) && !string.IsNullOrEmpty(order.guest_code))
            {
                var guest = await _context.PfbGuests
                    .FirstOrDefaultAsync(m => m.GuestCode == order.guest_code);

                if (guest != null)
                {
                    order.guest_name = guest.GName;
                }
            }
        }

        private async Task<(Dictionary<string, string>, Dictionary<string, string>)> ProcessOrderItems(OrderItem order, string outletId)
        {
            var orderNos = new Dictionary<string, string>();
            var usedGroup = new Dictionary<string, string>();

            if (order.CartItem?.Any() == true)
            {
                var ktCode = await GetKTCode(order.PosCode);

                foreach (var item in order.CartItem)
                {
                    //  Get group code 
                    var groupCode = await GetGroupCode(item.ItemCode, order.PosCode, ktCode);

                    
                    if (string.IsNullOrEmpty(groupCode))
                    {
                        groupCode = item.ItemCode; // Item code becomes group code
                    }

                    if (usedGroup.ContainsKey(groupCode))
                    {
                        orderNos[item.ItemCode] = usedGroup[groupCode];
                    }
                    else
                    {
                        var orderNo = await GetNextOrderNumber(item.ItemCode, order.PosCode, ktCode);
                        orderNos[item.ItemCode] = orderNo;
                        usedGroup[groupCode] = orderNo;

                        await UpdateOrderNumberSeries(orderNo, order.PosCode, ktCode);
                    }
                }
            }

            return (orderNos, usedGroup);
        }

        private async Task<string> GetKTCode(string pos)
        {
            var ktCode = await _context.PfbOrderMasters
                .Where(k => k.Description == "guest")
                .Select(k => k.Otypecode)
                .FirstOrDefaultAsync();

            return string.IsNullOrEmpty(ktCode) ? "GUEST" : ktCode;
        }

        private async Task<string> GetGroupCode(string rmnuCod, string pos, string ktCode)
        {
            var rmnuTyp = await _context.PfbMenuitemMasters
                .Where(r => r.ItemCode == rmnuCod)
                .Select(r => r.ItemGroup)
                .FirstOrDefaultAsync();

            var groupCode = await _context.PfbIgposMsts
                .Where(i => i.GrpCod == rmnuTyp && i.Pos == pos && i.OdrbilType == "O" && i.OrderCode == ktCode)
                .Select(i => i.OdrbilSer)
                .FirstOrDefaultAsync();

            return groupCode;
        }

        private async Task<string> GetNextOrderNumber(string rmnuCod, string posCode, string ktCode)
        {
            try
            {
                var itemExists = await _context.PfbMenuitemMasters
                    .AnyAsync(r => r.ItemCode == rmnuCod);

                if (!itemExists)
                {
                    Console.WriteLine($"Item not found: {rmnuCod}");
                    return null;
                }

                // Step 1: Get Item Group
                var rmnuTyp = await _context.PfbMenuitemMasters
                    .Where(r => r.ItemCode == rmnuCod)
                    .Select(r => r.ItemGroup)
                    .FirstOrDefaultAsync();

                // Step 2: Get Series
                var series = await _context.PfbIgposMsts
                    .Where(i => i.GrpCod == rmnuTyp && i.Pos == posCode && i.OdrbilType == "O" && i.OrderCode == ktCode)
                    .Select(i => i.OdrbilSer)
                    .FirstOrDefaultAsync();

                
                // Step 3: Get Current Number
                var currentNo = await _context.PfbSeriesMsts
                    .Where(s => s.SerNo == series && s.Odrbil == "O" && s.PosCode == posCode && s.OrderCode == ktCode)
                    .Select(s => s.CurNo)
                    .FirstOrDefaultAsync();

                return currentNo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }

        //private async Task UpdateOrderNumberSeries(string currentOrderNo, string pos, string ktCode)
        //{
        //    if (string.IsNullOrEmpty(currentOrderNo)) return;

        //    var len = currentOrderNo.Length;
        //    if (len < 3) return;

        //    var prefix = currentOrderNo.Substring(0, 2);
        //    var numberPart = currentOrderNo.Substring(2, len - 2);

        //    if (int.TryParse(numberPart, out var currentNumber))
        //    {
        //        currentNumber++;
        //        var zeros = new string('0', Math.Max(0, numberPart.Length - currentNumber.ToString().Length));
        //        var newOrderNo = prefix + zeros + currentNumber;

        //        var seriesCode = prefix; // Example: "OR", "KT", etc.
        //        var series = await _context.PfbSeriesMsts
        //            .FirstOrDefaultAsync(s => s.SerNo == seriesCode && s.Odrbil == "O" && s.PosCode == pos && s.OrderCode == ktCode);
        //        //var seriesCode = prefix;
        //        //var series = await _context.PfbSeriesMsts
        //        //    .FirstOrDefaultAsync(s => s.CurNo == seriesCode && s.Odrbil == "O" && s.PosCode == pos && s.OrderCode == ktCode);

        //        if (series != null)
        //        {
        //            series.CurNo = newOrderNo;
        //            _context.PfbSeriesMsts.Update(series);
        //            await _context.SaveChangesAsync();
        //        }
        //    }
        //}


        private async Task UpdateOrderNumberSeries(string currentOrderNo, string pos, string ktCode)
        {
            if (string.IsNullOrEmpty(currentOrderNo)) return;

            try
            {
                var len = currentOrderNo.Length;
                if (len < 3) return;

                var prefix = currentOrderNo.Substring(0, 2);
                var numberPart = currentOrderNo.Substring(2, len - 2);

                if (int.TryParse(numberPart, out var currentNumber))
                {
                    currentNumber++;
                    var zeros = new string('0', Math.Max(0, numberPart.Length - currentNumber.ToString().Length));
                    var newOrderNo = prefix + zeros + currentNumber;

                    var series = await _context.PfbSeriesMsts
                        .FirstOrDefaultAsync(s => s.CurNo == currentOrderNo && s.Odrbil == "O" && s.PosCode == pos && s.OrderCode == ktCode);

                    if (series != null)
                    {
                        series.CurNo = newOrderNo;
                        _context.PfbSeriesMsts.Update(series);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating order number series");
            }
        }

        private async Task InsertOrderDetails(OrderItem order, Dictionary<string, string> orderNos, Dictionary<string, string> usedGroup, string outletId, string userId)
        {
            try
            {
                var ktCode = await GetKTCode(order.PosName);

                string? finalOrderNo = null;

                foreach (var item in order.CartItem)
                {
                    try
                    {
                        var orderNo = orderNos.ContainsKey(item.ItemCode)
                            ? orderNos[item.ItemCode]
                            : order.OrderNumber;

                        // Store first order number (useful for RkotSum)
                        if (finalOrderNo == null)
                            finalOrderNo = orderNo;

                        // Insert RKOT_TRN as before
                        var rkotTrn = new PfbRkotTrn
                        {
                            RkotPop = order.PosCode,
                            OutletId = outletId,
                            RkotNo = orderNo,
                            RkotTyp = ktCode,
                            RkotMnu = item.ItemCode,
                            RkotRat = (decimal?)item.Price,
                            RkotQty = (decimal?)item.Quantity,
                            RkotSno = SearialNo,
                            RkotDat = order.Date,
                            RkotTaxtyp = item.TaxType,
                            RkotRem = item.RKOT_REM?.Replace("'", " ") ?? "",
                            RkotStax = item.TaxStruCode,
                            RkotTax = (decimal?)item.RKOT_TAX,
                            RmnuRat = (decimal?)item.Rmnu_RAT,
                            RkotDisc = item.DiscountPer2,
                            RkotCombo = "N",
                            RkotAddon = item.RKOT_ADDON,
                            RkotIsaddon = item.IsAddon,
                            RkotModifier = item.RKOT_Modifier,
                            RkotSubItem = item.IsSubItem,
                            RkotWqty = 0.00m,
                            ComboCode = item.COMBO_CODE,
                            ComboFlag = "",
                            RkotType = item.RKOT_TYPE,
                            HhDisc = 0.00m,
                            FnlBaseVal = (decimal?)(item.Quantity * item.Price),
                            DiscAmt = item.Discount2
                        };

                        _context.PfbRkotTrns.Add(rkotTrn);
                        await _context.SaveChangesAsync();

                        await ProcessRelatedInserts(order, item, orderNo);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error processing cart item {ItemCode} for order {OrderNo}. Item: {ItemName}",
                            item.ItemCode, order.OrderNumber, item.ItemName);
                    }
                }

                // Pass finalOrderNo to InsertRkotSum
                if (finalOrderNo != null)
                    await InsertRkotSum(order, ktCode, outletId, finalOrderNo, userId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inserting order details for order {OrderNumber}. Table: {TableNumber}, POS: {POS}",
                    order.OrderNumber, order.TableNumber, order.PosName);
                throw;
            }
        }


        //private async Task InsertOrderDetails(OrderItem order, Dictionary<string, string> orderNos, Dictionary<string, string> usedGroup, string outletId)
        //{
        //    try
        //    {
        //        var ktCode = await GetKTCode(order.PosName);

        //        foreach (var item in order.CartItem)
        //        {
        //            try
        //            {
        //                var orderNo = orderNos.ContainsKey(item.ItemCode) ? orderNos[item.ItemCode] : order.OrderNumber;

        //                // Insert RKOT_TRN
        //                var rkotTrn = new PfbRkotTrn
        //                {
        //                    //RkotPop = order.PosName,
        //                    RkotPop = order.PosCode,
        //                    OutletId = outletId,
        //                    RkotNo = orderNo,
        //                    RkotTyp = ktCode,
        //                    RkotMnu = item.ItemCode,
        //                    RkotRat = (decimal?)item.Price,
        //                    RkotQty = (decimal?)item.Quantity,
        //                    //RkotSno = item.SearialNo,
        //                    RkotSno = SearialNo,
        //                    RkotDat = order.Date,
        //                    RkotTaxtyp = item.TaxType,
        //                    RkotRem = item.RKOT_REM?.Replace("'", " ") ?? "",
        //                    RkotStax = item.TaxStruCode,
        //                    RkotTax = (decimal?)item.RKOT_TAX,
        //                    RmnuRat = (decimal?)item.Rmnu_RAT,
        //                    RkotDisc = item.DiscountPer2,
        //                    RkotCombo = "N",
        //                    RkotAddon = item.RKOT_ADDON,
        //                    RkotIsaddon = item.IsAddon,
        //                    RkotModifier = item.RKOT_Modifier,
        //                    RkotSubItem = item.IsSubItem,
        //                    RkotWqty = 0.00m,
        //                    ComboCode = item.COMBO_CODE,
        //                    ComboFlag = "",
        //                    RkotType = item.RKOT_TYPE,
        //                    HhDisc = 0.00m,
        //                    FnlBaseVal = (decimal?)(item.Quantity * item.Price),
        //                    DiscAmt = item.Discount2
        //                };

        //                _context.PfbRkotTrns.Add(rkotTrn);
        //                await _context.SaveChangesAsync();
        //                // Process KDS and other related inserts
        //                await ProcessRelatedInserts(order, item, orderNo);
        //            }
        //            catch (Exception ex)
        //            {
        //                _logger.LogError(ex, "Error processing cart item {ItemCode} for order {OrderNo}. Item: {ItemName}",
        //                    item.ItemCode, order.OrderNumber, item.ItemName);

        //                // Continue with next item instead of failing the entire order
        //                //continue;
        //            }
        //        }

        //        // Insert into RKOT_SUM
        //        await InsertRkotSum(order, ktCode, outletId);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error inserting order details for order {OrderNumber}. Table: {TableNumber}, POS: {POS}",
        //            order.OrderNumber, order.TableNumber, order.PosName);
        //        throw; // Re-throw to maintain transaction rollback
        //    }
        //}

        private async Task ProcessRelatedInserts(OrderItem order, CartItems item, string orderNo)
        {
            try
            {
                // Get POP location
                var popLocation = await _context.PfbOutletposMsts
                    .Where(r => r.PosCode == _context.PfbMenuitemMasters
                        .Where(rm => rm.ItemCode == item.ItemCode)
                        .Select(rm => rm.KitchenDept)
                        .FirstOrDefault())
                    .Select(r => r.PosDesc)
                    .FirstOrDefaultAsync() ?? order.PosName;

                // Insert into KDS_TRN
                var kdsTrn = new PfbKdsTrn
                {
                    PosName = popLocation,
                    VNo = orderNo,
                    Qty = (short)item.Quantity,
                    ItemName = item.ItemName,
                    ItemColor = 8454143,
                    Sts = "S",
                    Rate = (float)item.Price,
                    ItemTime = order.Date?.ToString("HH:mm:ss") ?? string.Empty,
                    Remark = item.RKOT_REM?.Replace("'", " ") ?? ""
                };

                _context.PfbKdsTrns.Add(kdsTrn);
                await _context.SaveChangesAsync();

                // Process sub items
                if (item.SubItem != null)
                {
                    await ProcessSubItems(order, item, orderNo, popLocation);
                }

                // Process RKOT_MAN entries
                await ProcessRkotManEntries(order, item, orderNo);
            }
                catch (Exception)
            {

            }
            
        }

        private async Task ProcessSubItems(OrderItem order, CartItems item, string orderNo, string popLocation)
        {
            //var date = order.Date.ToString("yyyy/MM/dd");
            try
            {
                foreach (var subItem in item.SubItem)
                {
                    if (item.GRP_SUB == "y")
                    {
                        // Insert into Pfb_SubItem_Trn
                        var subItemTrn = new PfbSubItemTrn
                        {
                            //RkotPop = order.PosName,
                            RkotPop = order.PosName?.Length > 6 ? order.PosName.Substring(0, 6) : order.PosName,
                            RkotNo = orderNo,
                            RkotDat = order.Date,
                            RkotMnu = item.ItemCode,
                            RkotSno = SearialNo,
                            RkotSubitem = subItem.RKOT_SUBITEM,
                            SubSn = 1,
                            Flag = "1"
                        };

                        _context.PfbSubItemTrns.Add(subItemTrn);
                        await _context.SaveChangesAsync();

                        // Get sub item name
                        var subName = await GetSubItemName(item.ItemCode, subItem.RKOT_SUBITEM);

                        // Insert into KDS_TRN for sub item
                        var kdsSubTrn = new PfbKdsTrn
                        {
                            PosName = popLocation,
                            VNo = orderNo,
                            Qty = (short?)item.Quantity,
                            ItemName = subName,
                            ItemColor = 8454143,
                            Sts = "S",
                            Rate = item.Rmnu_RAT,
                            Remark = item.RKOT_REM?.Replace("'", " ") ?? ""
                        };

                        _context.PfbKdsTrns.Add(kdsSubTrn);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private async Task<string> GetSubItemName(string itemCode, string subItemCode)
        {
            var subName = await _context.PfbSubItems
                .Where(s => s.GrpId == _context.PfbGrpSubItems
                    .Where(g => g.ItemCode == itemCode)
                    .Select(g => g.Id)
                    .FirstOrDefault() && s.Id == subItemCode)
                .Select(s => s.SubName)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(subName))
            {
                subName = await _context.PfbCommonSubItems
                    .Join(_context.PfbCommonGrpSubItems,
                        csi => csi.GrpId,
                        cgsi => cgsi.Id,
                        (csi, cgsi) => new { csi, cgsi })
                    .Join(_context.PfbMenuRates.Where(r => r.Pos == "POS"),
                        joined => joined.csi.Id,
                        r => r.RmnuSubId,
                        (joined, r) => new { joined.csi, joined.cgsi })
                    .Where(x => x.csi.Id == subItemCode)
                    .Select(x => x.csi.SubName)
                    .FirstOrDefaultAsync();
            }

            return subName ?? "Unknown Sub Item";
        }

        private async Task ProcessRkotManEntries(OrderItem order, CartItems item, string orderNo)
        {
            //var date = order.Date;

            if (item.RMNU_MODF == "1" || !string.IsNullOrEmpty(item.RKOT_REM))
            {
                if (item.RMNU_MODF == "1")
                {
                    // Insert description
                    var rkotManDesc = new PfbRkotMan
                    {
                        Pos = order.PosName,
                        KotDate = order.Date,
                        Kotno = orderNo,
                        Code = item.ItemCode,
                        Desci = item.ItemName,
                        DesOrrem = "D",
                        RkotSno = SearialNo
                    };
                    _context.PfbRkotMen.Add(rkotManDesc);

                    if (!string.IsNullOrEmpty(item.RKOT_REM))
                    {
                        // Insert remark
                        var rkotManRem = new PfbRkotMan
                        {
                            Pos = order.PosName,
                            KotDate = order.Date,
                            Kotno = orderNo,
                            Code = item.ItemCode,
                            Desci = item.RKOT_REM.Replace("'", " "),
                            DesOrrem = "R",
                            RkotSno = SearialNo
                        };
                        _context.PfbRkotMen.Add(rkotManRem);
                    }
                }
                else if (!string.IsNullOrEmpty(item.RKOT_REM))
                {
                    // Insert only remark
                    var rkotManRem = new PfbRkotMan
                    {
                        Pos = order.PosName,
                        KotDate = order.Date,
                        Kotno = orderNo,
                        Code = item.ItemCode,
                        Desci = item.RKOT_REM.Replace("'", " "),
                        DesOrrem = "R",
                        RkotSno = SearialNo
                    };
                    _context.PfbRkotMen.Add(rkotManRem);
                }
                await _context.SaveChangesAsync();
            }
            SearialNo++;
        }

        private async Task InsertRkotSum(OrderItem order, string ktCode, string outletId, string finalOrderNo, string userId)
        {
            try
            {
                var totalAmt = order.CartItem?.Sum(item => item.Quantity * item.Price) ?? 0;

                var existingSum = await _context.PfbRkotSums
                    .FirstOrDefaultAsync(s => s.RsumPop == order.PosName &&
                                             s.RsumTbl == order.TableNumber &&
                                             s.RsumKot == finalOrderNo && 
                                             s.RsumSts == "K");

                if (existingSum != null)
                {
                    existingSum.RsumAmt += (decimal)totalAmt;
                    _context.PfbRkotSums.Update(existingSum);
                }
                else
                {
                    var rkotSum = new PfbRkotSum
                    {
                        RsumKds = "S",
                        RsumPop = order.PosCode,
                        OutletId = outletId,
                        RsumKot = finalOrderNo,
                        //RsumDat = order.Date.Date,
                        RsumDat = order.Date.HasValue ? order.Date.Value.Date : DateTime.MinValue,
                        RsumTbl = order.TableNumber,
                        RsumTyp = ktCode,
                        RsumGcd = order.guest_code,
                        RsumNar = order.guest_code,
                        RsumGcdName = order.guest_name,
                        RsumRem = order.RSUM_REM,
                        RsumSts = order.OrderStatus,
                        RsumCvr = short.TryParse(order.RSUM_CVR, out var parsedCvr) ? parsedCvr : (short?)null,
                        RsumSubtbl = order.RSUM_SUBTBL,
                        //RsumTim = order.RSUM_TIM,
                        RsumTim = order.Date.HasValue ? order.Date.Value.ToString("HH:mm") : string.Empty,
                        RsumCsh = userId,
                        RsumEdt = order.RSUM_EDT,
                        RsumAmt = (decimal?)totalAmt,
                        RsumNo = short.TryParse(order.RSUM_NO, out var parsedRsumNo) ? parsedRsumNo : (short?)null,
                        RsumRemtyp = order.RSUM_REMTYP,
                        RsumStw = order.RSUM_STW
                    };

                    _context.PfbRkotSums.Add(rkotSum);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Unexpected Error] InsertRkotSum failed: {ex.Message}");
                throw;
            }
        }


        //private async Task InsertRkotSum(OrderItem order, string ktCode, string outletId)
        //{
        //    try
        //    {
        //        var totalAmt = order.CartItem?.Sum(item => item.Quantity * item.Price) ?? 0;

        //        // Check if summary already exists
        //        var existingSum = await _context.PfbRkotSums
        //            .FirstOrDefaultAsync(s => s.RsumPop == order.PosName &&
        //                                     s.RsumTbl == order.TableNumber &&
        //                                     s.RsumKot == order.OrderNumber &&
        //                                     s.RsumSts == "K");

        //        if (existingSum != null)
        //        {
        //            // Update existing
        //            existingSum.RsumAmt += (decimal)totalAmt;
        //            _context.PfbRkotSums.Update(existingSum);
        //        }
        //        else
        //        {
        //            // Insert new
        //            var rkotSum = new PfbRkotSum
        //            {
        //                RsumKds = "S",
        //                RsumPop = order.PosCode,
        //                OutletId = outletId,
        //                //RsumPop = order.PosName?.Length > 6 ? order.PosName.Substring(0, 6) : order.PosName,
        //                RsumKot = order.OrderNumber ?? string.Empty,
        //                RsumDat = order.Date,
        //                RsumTbl = order.TableNumber,
        //                RsumTyp = ktCode,
        //                RsumGcd = order.guest_code,
        //                RsumNar = order.guest_code,
        //                RsumGcdName = order.guest_name,
        //                RsumRem = order.RSUM_REM,
        //                RsumSts = order.OrderStatus,
        //                RsumCvr = short.TryParse(order.RSUM_CVR, out var parsedCvr) ? parsedCvr : (short?)null,
        //                RsumSubtbl = order.RSUM_SUBTBL,
        //                RsumTim = order.RSUM_TIM,
        //                RsumCsh = order.RSUM_CSH,
        //                RsumEdt = order.RSUM_EDT,
        //                RsumAmt = (decimal?)totalAmt, 
        //                RsumNo = short.TryParse(order.RSUM_NO, out var parsedRsumNo) ? parsedRsumNo : (short?)null,
        //                RsumRemtyp = order.RSUM_REMTYP,
        //                RsumStw = order.RSUM_STW
        //            };

        //            _context.PfbRkotSums.Add(rkotSum);
        //        }

        //        await _context.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"[Unexpected Error] InsertRkotSum failed: {ex.Message}");
        //        throw;
        //    }
        //}


        private async Task UpdateTableStatus(OrderItem order, string outletId)
        {
            try
            {
                var table = await _context.PfbRmscMsts
                    .FirstOrDefaultAsync(t => t.RmscPop == order.PosCode &&
                                              t.RmscCod == order.TableNumber &&
                                              t.OutletId == outletId);

                if (table != null)
                {
                    table.RmscTblsts = "K";
                    _context.PfbRmscMsts.Update(table);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    Console.WriteLine($"[WARN] Table not found: PosCode={order.PosCode}, Table={order.TableNumber}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Unexpected Error] UpdateTableStatus failed: {ex.Message}");
                throw;
            }
        }


        //private async Task InsertPrintQueueEntries(Dictionary<string, string> usedGroup, string pos)
        //{
        //    foreach (var orderEntry in usedGroup)
        //    {
        //        var printQueue = new rms_pda_prnq
        //        {
        //            POS_ID = pos,
        //            Order_Bill_No = orderEntry.Value,
        //            PRN_FLAG = "O"
        //        };

        //        _context.rms_pda_prnq.Add(printQueue);
        //    }

        //    await _context.SaveChangesAsync();
        //}

        private async Task LogTransactionStart(string outletId, string userId)
        {
            try
            {
                var transLog = new CsatcloudUsageLog
                {
                    ModCode = "CSATHH",
                    OutletId = outletId,
                    Uid = userId,
                    SysIp = Dns.GetHostName(),
                    Login = DateTime.Now,
                    Logout = DateTime.Now,
                    //trans_type = "KOTGEN",
                    //trans_refno = orderNo,
                    //op_type = "A",
                    //Remarks = "End",
                    //Process_id = "CSATHH",
                    //Form_id = "V1.3"
                };

                _context.CsatcloudUsageLogs.Add(transLog);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner: {ex.InnerException.Message}");
                }
                throw; // optional, agar error propagate karna ho
            }
        }



        private async Task LogTransactionEnd(string outletId, string userId, string orderNo)
        {
            var transLog = new CsatcloudUsageLog
            {
                ModCode = "CSATHH",
                OutletId = outletId,
                Uid = userId,
                SysIp = Dns.GetHostName(),
                Login = DateTime.Now,
                Logout = DateTime.Now,
                //trans_type = "KOTGEN",
                //trans_refno = orderNo,
                //op_type = "A",
                //Remarks = "End",
                //Process_id = "CSATHH",
                //Form_id = "V1.3"
            };

            _context.CsatcloudUsageLogs.Add(transLog);
            await _context.SaveChangesAsync();
        }
    }
}
