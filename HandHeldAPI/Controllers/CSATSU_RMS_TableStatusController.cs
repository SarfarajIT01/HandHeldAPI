
using HandHeldAPI.Data;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSATSU_RMS_TableStatusController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_TableStatusController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PfbRmscMst>>> Get()
         {
            try
            {
                var result = new List<PfbRmscMst>();

                var tables = await _context.PfbRmscMsts
                    .Where(x => x.RmscTyp == "tbl" || x.RmscTyp == "rom")
                    .OrderBy(x => x.RmscFloor)
                    .ThenBy(x => x.RmscRow)
                    .ThenBy(x => x.RmscColumn)
                    .ToListAsync();

                foreach (var t in tables)
                {
                    var obj = new PfbRmscMst
                    {
                        OutletId = t.OutletId,
                        //RmscStd = t.RmscStd,
                        RmscCod = t.RmscCod,
                        RmscPop = t.RmscPop,
                        RmscTyp = t.RmscTyp,
                        RmscTblsts = t.RmscTblsts,
                        RmscFloor = t.RmscFloor,
                        RmscRow = t.RmscRow,
                        RmscColumn = t.RmscColumn,
                        FloorDesc = ""
                    };

                    if (!string.IsNullOrEmpty(t.RmscFloor) && t.RmscFloor != "0")
                    {
                        var floor = await _context.PfbFloors
                            .FirstOrDefaultAsync(f => f.FloorId == t.RmscFloor);
                        obj.FloorDesc = floor?.FloorDesc ?? "";
                    }
                    else
                    {
                        obj.FloorDesc = t.RmscFloor;
                    }

                    float Amt = 0;
                    string Cover = "";
                    string STW = "";
                    string Selectedguestcode = "";
                    string Selectedguest = "";

                    // Running Orders (RSUM_STS = K)
                    var running = await _context.PfbRkotSums
                        .Where(r => r.RsumTbl == t.RmscStd
                                    && r.RsumPop == t.RmscPop
                                    && r.RsumSts == "K")
                        .ToListAsync();

                    if (running.Any())
                    {
                        foreach (var r in running)
                        {
                            Amt += float.TryParse(r.RsumAmt?.ToString(), out var v) ? v : 0;
                            Cover = r.RsumCvr.HasValue ? r.RsumCvr.Value.ToString() : string.Empty;
                            STW = r.RsumStw;
                            Selectedguestcode = r.RsumGcd;
                            Selectedguest = r.RsumGcdName;
                        }
                    }
                    else
                    {
                        // Billed Orders (RSUM_STS = B)
                        var billed = await _context.PfbRkotSums
                            .Where(r => r.RsumTbl == t.RmscStd
                                        && r.RsumPop == t.RmscPop
                                        && r.RsumSts == "B")
                            .ToListAsync();

                        if (billed.Any())
                        {
                            foreach (var b in billed)
                            {
                                if (!string.IsNullOrEmpty(b.RsumBil))
                                {
                                    var bill = await _context.PfbRbillSums
                                        .FirstOrDefaultAsync(x => x.RbilNo == b.RsumTbl && x.RbilSts == "B");

                                    if (bill != null)
                                    {
                                        if (bill.RbilRound.HasValue)
                                            Amt = (float)bill.RbilRound.Value;
                                        else if (!string.IsNullOrEmpty(bill.RbilCvchr2))
                                            Amt = float.TryParse(bill.RbilCvchr2, out var parsedValue) ? parsedValue : 0;
                                    }
                                }
                            }
                        }
                    }

                    var arrival = await _context.PfbTableArrivals
                        .FirstOrDefaultAsync(a => a.ArrDate == DateTime.Today && a.TableNo == t.RmscStd);

                    if (arrival != null)
                    {
                        Selectedguestcode = arrival.GuestId;
                        Selectedguest = arrival.GuestName;
                    }

                    obj.TableAmt = Amt;
                    obj.RunCvr = Cover;
                    obj.RunSTW = STW;
                    obj.RunGuestCode = Selectedguestcode;
                    obj.RunGuestName = Selectedguest;

                    result.Add(obj);
                }

                return Ok(result);
            }
                catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        // ================== GET BY ID ==================
        [HttpGet("GetByID/{RLOC_TYPE}")]
        public async Task<ActionResult<List<PfbRmscMst>>> GetByID(string RLOC_TYPE)
        {
            try
            {
                var result = new List<PfbRmscMst>();

                if (RLOC_TYPE == "S")
                {
                    var rooms = await _context.PfbRmscMsts
                        .Where(x => x.RmscTyp == "rom")
                        .ToListAsync();

                    foreach (var r in rooms)
                    {
                        result.Add(new PfbRmscMst
                        {
                            RmscStd = r.RmscStd,
                            RmscCod = r.RmscCod,
                            RmscTyp = r.RmscTyp,
                            RmscPop = r.RmscPop,
                            RmscTblsts = r.RmscTblsts,
                            RmscStatus = r.RmscStatus,
                            RmscRow = r.RmscRow,
                            RmscColumn = r.RmscColumn
                        });
                    }
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        // ================== PUT ==================
        [HttpPut]
        public async Task<ActionResult<string>> Put([FromBody] PfbRmscMst msc)
        {
            try
            {
                if (string.IsNullOrEmpty(msc.RmscPop) || string.IsNullOrEmpty(msc.RmscCod))
                    return BadRequest("Missing POP or COD");

                var table = await _context.PfbRmscMsts
                    .FirstOrDefaultAsync(x => x.RmscTyp == "TBL"
                                           && x.RmscPop == msc.RmscPop
                                           && x.RmscCod == msc.RmscCod);

                if (table != null)
                {
                    table.RmscTblsts = "";
                    await _context.SaveChangesAsync();
                    return Ok("Update Successfull ..!");
                }

                return NotFound("Table not found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }

}
