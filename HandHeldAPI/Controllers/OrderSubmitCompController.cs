//using HandHeldAPI.Data;
//using HandHeldAPI.Models.DTOs;
//using HandHeldAPI.Models.HandHeld;
//using HandHeldAPI.Services;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;

//namespace HandHeldAPI.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class CSATSU_RMS_SubmitOrderCompController : ControllerBase
//    {
//        private readonly HandHeldDbContext _context;
//        private readonly IConfiguration _configuration;
//        private readonly ILogger<CSATSU_RMS_SubmitOrderCompController> _logger;

//        public CSATSU_RMS_SubmitOrderCompController(
//            HandHeldDbContext context,
//            IConfiguration configuration,
//            ILogger<CSATSU_RMS_SubmitOrderCompController> logger)
//        {
//            _context = context;
//            _configuration = configuration;
//            _logger = logger;
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] OrderSubmit2 order)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            try
//            {
//                // Extract headers
//                if (!Request.Headers.TryGetValue("clientId", out var clientIdHeader) ||
//                    !Request.Headers.TryGetValue("Token", out var tokenHeader))
//                {
//                    return BadRequest("Missing required headers");
//                }

//                string clientId = clientIdHeader.ToString();
//                string accessToken = tokenHeader.ToString();

//                // Validate token (implement your token validation logic)
//                var tokenValidationResult = await ValidateTokenAsync(accessToken, clientId);
//                if (!tokenValidationResult.IsValid)
//                {
//                    return Unauthorized("Invalid token");
//                }

//                var result = await ProcessOrderAsync(order, clientId, tokenValidationResult.UserId);
//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Error processing order");
//                return StatusCode(500, ex.Message);
//            }
//        }

//        private async Task<string> ProcessOrderAsync(OrderSubmit2 order, string clientId, string userId)
//        {
//            using var transaction = await _context.Database.BeginTransactionAsync();

//            try
//            {
//                string rmsCompBill = await GetRmsCompBillAsync();
//                string orderStatus = rmsCompBill == "y" ? "K" : order.OrderStatus;
//                string ktCode = "COMP";

//                var orderNumbers = new Dictionary<string, string>();
//                var usedGroups = new Dictionary<string, string>();

//                // Process order items and generate order numbers
//                await ProcessOrderItemsAsync(order, ktCode, orderNumbers, usedGroups);

//                // Update table status and series
//                await UpdateTableStatusAndSeriesAsync(order, ktCode, orderNumbers.Values.FirstOrDefault(), rmsCompBill, userId);

//                await transaction.CommitAsync();
//                return "Insert Successfully";
//            }
//            catch
//            {
//                await transaction.RollbackAsync();
//                throw;
//            }
//        }

//        private async Task<string> GetRmsCompBillAsync()
//        {
//            return await _context.RmsMst1
//                .Select(m => m.RMS_COMP_BILL)
//                .FirstOrDefaultAsync() ?? "n";
//        }

//        private async Task ProcessOrderItemsAsync(OrderSubmit2 order, string ktCode,
//            Dictionary<string, string> orderNumbers, Dictionary<string, string> usedGroups)
//        {
//            foreach (var item in order.itemdata)
//            {
//                string orderNo = await GetOrCreateOrderNumberAsync(item, ktCode, order.POS, orderNumbers, usedGroups);

//                // Insert RKOT_TRN
//                await InsertRkotTrnAsync(item, order, ktCode, orderNo);

//                // Insert SUB_ITEM_TRN if needed
//                if (item.GRP_SUB == "y")
//                {
//                    await InsertSubItemTrnAsync(item, order, orderNo);
//                }

//                // Insert RKOT_MAN
//                await InsertRkotManAsync(item, order, orderNo);

//                // Update RKOT_SUM
//                await UpdateRkotSumAsync(order, orderNo, ktCode, item.RKOT_RAT, userId);
//            }
//        }

//        private async Task<string> GetOrCreateOrderNumberAsync(ItemDetail22 item, string ktCode, string pos,
//            Dictionary<string, string> orderNumbers, Dictionary<string, string> usedGroups)
//        {
//            if (orderNumbers.TryGetValue(item.RKOT_MNU, out var existingOrderNo))
//            {
//                return existingOrderNo;
//            }

//            var groupCode = await _context.RmsIgposMst
//                .Where(ig => ig.GrpCod == _context.RmsRmnuMst
//                    .Where(rm => rm.RMNU_COD == item.RKOT_MNU)
//                    .Select(rm => rm.RMNU_TYP)
//                    .FirstOrDefault())
//                .Where(ig => ig.Pos == pos && ig.OdrbilType == "O" && ig.OrderCode == ktCode)
//                .Select(ig => ig.OdrbilSer)
//                .FirstOrDefaultAsync();

//            if (usedGroups.TryGetValue(groupCode, out var orderNo))
//            {
//                orderNumbers[item.RKOT_MNU] = orderNo;
//                return orderNo;
//            }

//            var currentNo = await _context.RmsSeriesMst
//                .Where(s => s.SerNo == groupCode && s.Odrbil == "O")
//                .Select(s => s.CurNo)
//                .FirstOrDefaultAsync();

//            if (currentNo == null)
//            {
//                currentNo = await _context.RmsSeriesMst
//                    .Where(s => s.SerNo == "B" && s.Odrbil == "B" && s.PosCode == pos)
//                    .Select(s => s.CurNo)
//                    .FirstOrDefaultAsync();
//            }

//            orderNumbers[item.RKOT_MNU] = currentNo;
//            usedGroups[groupCode] = currentNo;

//            // Update series
//            var nextOrderNo = GenerateNextOrderNumber(currentNo);
//            var series = await _context.RmsSeriesMst
//                .FirstOrDefaultAsync(s => s.CurNo == currentNo && s.Odrbil == "B" && s.PosCode == pos);

//            if (series != null)
//            {
//                series.CurNo = nextOrderNo;
//                _context.RmsSeriesMst.Update(series);
//            }

//            return currentNo;
//        }

//        private string GenerateNextOrderNumber(string currentNo)
//        {
//            int len = currentNo.Length;
//            string prefix = currentNo.Substring(0, 2);
//            string numberPart = currentNo.Substring(2, len - 2);

//            if (int.TryParse(numberPart, out int number))
//            {
//                number++;
//                int zeroCount = numberPart.Length - number.ToString().Length;
//                string zeros = new string('0', zeroCount > 0 ? zeroCount : 0);
//                return prefix + zeros + number;
//            }

//            return currentNo;
//        }

//        private async Task InsertRkotTrnAsync(ItemDetail22 item, OrderSubmit2 order, string ktCode, string orderNo)
//        {
//            var rkotTrn = new RmsRkotTrn
//            {
//                RKOT_POP = order.POS,
//                RKOT_NO = orderNo,
//                RKOT_TYP = ktCode,
//                RKOT_MNU = item.RKOT_MNU,
//                RKOT_RAT = item.RKOT_RAT,
//                RKOT_QTY = item.RKOT_QTY,
//                RKOT_SNO = item.RKOT_SNO,
//                RKOT_DAT = order.Date,
//                RKOT_TAXTYP = item.RKOT_TAXTYP,
//                RKOT_REM = item.RMNU_MODF == "1" ? "R" : item.RKOT_REM,
//                RKOT_STax = item.RKOT_STax,
//                RKOT_TAX = item.RKOT_TAX,
//                Rmnu_RAT = item.Rmnu_RAT,
//                RKOT_DISC = 100,
//                RKOT_Combo = "N",
//                RKOT_ADDON = item.RKOT_ADDON,
//                RKOT_ISAddon = item.RKOT_ISAddon,
//                RKOT_Modifier = item.RKOT_Modifier,
//                RKOT_SubItem = item.RKOT_SubItem,
//                GRP_SUB = item.GRP_SUB,
//                RKOT_WQTY = 0.00m,
//                COMBO_CODE = "",
//                COMBO_FLAG = "",
//                RKOT_TYPE = item.RKOT_TYPE,
//                HH_DISC = 0.00m
//            };

//            await _context.RmsRkotTrn.AddAsync(rkotTrn);
//            await _context.SaveChangesAsync();
//        }

//        private async Task InsertSubItemTrnAsync(ItemDetail22 item, OrderSubmit2 order, string orderNo)
//        {
//            var subItems = item.SUB_ITEM_TRN.Select(sub => new RmsSubItemTrn
//            {
//                RKOT_POP = order.POS,
//                RKOT_NO = orderNo,
//                RKOT_DAT = order.Date,
//                RKOT_MNU = item.RKOT_MNU,
//                RKOT_SNO = item.RKOT_SNO,
//                RKOT_SUBITEM = sub.RKOT_SUBITEM
//            });

//            await _context.RmsSubItemTrn.AddRangeAsync(subItems);
//            await _context.SaveChangesAsync();
//        }

//        private async Task InsertRkotManAsync(ItemDetail22 item, OrderSubmit2 order, string orderNo)
//        {
//            var rkotManEntries = new List<RmsRkotMan>();

//            if (item.RMNU_MODF == "1")
//            {
//                rkotManEntries.Add(new RmsRkotMan
//                {
//                    Pos = order.POS,
//                    Kot_DATE = order.Date,
//                    KOTNO = orderNo,
//                    CODE = item.RKOT_MNU,
//                    DESCI = item.ItemName,
//                    DesORRem = "D",
//                    RKOT_SNO = item.RKOT_SNO
//                });
//            }

//            if (!string.IsNullOrEmpty(item.RKOT_REM))
//            {
//                rkotManEntries.Add(new RmsRkotMan
//                {
//                    Pos = order.POS,
//                    Kot_DATE = order.Date,
//                    KOTNO = orderNo,
//                    CODE = item.RKOT_MNU,
//                    DESCI = item.RKOT_REM,
//                    DesORRem = "R",
//                    RKOT_SNO = item.RKOT_SNO
//                });
//            }

//            if (rkotManEntries.Any())
//            {
//                await _context.RmsRkotMan.AddRangeAsync(rkotManEntries);
//                await _context.SaveChangesAsync();
//            }
//        }

//        private async Task UpdateRkotSumAsync(OrderSubmit2 order, string orderNo, string ktCode, decimal amount, string userId)
//        {
//            var existingSum = await _context.RmsRkotSum
//                .FirstOrDefaultAsync(s => s.RSUM_POP == order.POS &&
//                                         s.RSUM_TBL == order.TableNo &&
//                                         s.RSUM_KOT == orderNo &&
//                                         s.RSUM_STS == "K");

//            if (existingSum != null)
//            {
//                existingSum.RSUM_AMT += amount;
//                _context.RmsRkotSum.Update(existingSum);
//            }
//            else
//            {
//                var newSum = new RmsRkotSum
//                {
//                    RSUM_KDS = "S",
//                    RSUM_POP = order.POS,
//                    RSUM_KOT = orderNo,
//                    RSUM_DAT = order.Date,
//                    RSUM_TBL = order.TableNo,
//                    RSUM_TYP = ktCode,
//                    RSUM_GCD = "",
//                    RSUM_GcdName = order.guest_code,
//                    RSUM_REM = order.RSUM_REM,
//                    RSUM_STS = "K",
//                    RSUM_CVR = order.RSUM_CVR,
//                    RSUM_SUBTBL = order.RSUM_SUBTBL ?? "",
//                    RSUM_TIM = order.RSUM_TIM,
//                    RSUM_CSH = order.RSUM_CSH,
//                    RSUM_EDT = order.RSUM_EDT,
//                    RSUM_AMT = order.RSUM_AMT,
//                    RSUM_NO = order.RSUM_NO,
//                    RSUM_REMTYP = order.RSUM_REMTYP,
//                    RSUM_STW = userId,
//                    Rsum_nar = order.guest_code
//                };

//                await _context.RmsRkotSum.AddAsync(newSum);

//                // Add to print queue
//                await _context.RmsPdaPrnq.AddAsync(new RmsPdaPrnq
//                {
//                    POS_ID = order.POS,
//                    Order_Bill_No = orderNo,
//                    PRN_FLAG = "O"
//                });
//            }

//            await _context.SaveChangesAsync();
//        }

//        private async Task UpdateTableStatusAndSeriesAsync(OrderSubmit2 order, string ktCode, string orderNo, string rmsCompBill, string userId)
//        {
//            var table = await _context.RmscMst
//                .FirstOrDefaultAsync(t => t.Rmsc_pop == order.POS && t.Rmsc_cod == order.TableNo);

//            if (table != null)
//            {
//                table.Rmsc_tblsts = (order.OrderType == "COMP" && rmsCompBill != "y") ? "" : "K";
//                _context.RmscMst.Update(table);
//            }

//            // Add transaction log
//            var transLog = new CabsTranslog
//            {
//                Mod_code = "CSATHH",
//                Comp_code = clientId,
//                Opr_id = userId,
//                Ter_ip_add = Dns.GetHostName(),
//                Ch_date = DateTime.Now,
//                Ch_time = DateTime.Now.ToString("t"),
//                Trans_type = "KOTGEN",
//                Trans_refno = orderNo,
//                Op_type = "A",
//                Remarks = "",
//                Process_id = "CSATHH",
//                Form_id = "V1.0"
//            };

//            await _context.CabsTranslog.AddAsync(transLog);
//            await _context.SaveChangesAsync();
//        }

//        private async Task<TokenValidationResult> ValidateTokenAsync(string token, string clientId)
//        {
//            // Implement your token validation logic here
//            // This is a placeholder implementation
//            try
//            {
//                var validatedToken = token; // Your token validation logic
//                var parts = validatedToken.Split('#');

//                return new TokenValidationResult
//                {
//                    IsValid = true,
//                    CompCode = parts[0],
//                    UserId = parts[1]
//                };
//            }
//            catch
//            {
//                return new TokenValidationResult { IsValid = false };
//            }
//        }
//    }

//    public class TokenValidationResult
//    {
//        public bool IsValid { get; set; }
//        public string CompCode { get; set; }
//        public string UserId { get; set; }
//    }
//}

