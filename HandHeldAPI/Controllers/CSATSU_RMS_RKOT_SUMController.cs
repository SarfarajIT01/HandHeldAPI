using HandHeldAPI.Data;
using HandHeldAPI.Models;
using HandHeldAPI.Models.DTOs;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSATSU_RMS_RKOT_SUMController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_RKOT_SUMController(HandHeldDbContext context)
        {
            _context = context;
        }

        // GET: api/RkotSum
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PfbRkotSumDto>>> GetAll()
        {
            try
            {
                var result = await _context.PfbRkotSums.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error fetching data: {ex.Message}");
            }
        }

        // GET: api/RkotSum/{tblno}
        [HttpGet("{tblno}")]
        public async Task<ActionResult<IEnumerable<PfbRkotSumDto>>> GetByTableNo(string tblno)
        {
            try
            {
                var result = await _context.PfbRkotSums
                    .Where(r => r.RsumTbl == tblno && r.RsumSts.ToLower() == "k")
                    .ToListAsync();

                if (result == null || result.Count == 0)
                    return NotFound("No records found for this table or bill already generated.");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error fetching table data: {ex.Message}");
            }
        }

        // POST: api/RkotSum
        [HttpPost]
        public async Task<ActionResult<string>> Create([FromBody] PfbRkotSum item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                bool exists = await _context.PfbRkotSums
                    .AnyAsync(r => r.RsumKot == item.RsumKot && r.RsumNo == item.RsumNo);

                if (exists)
                    return Ok("Not Inserted");

                await _context.PfbRkotSums.AddAsync(item);
                await _context.SaveChangesAsync();

                return Ok("Insert Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Insert failed: {ex.Message}");
            }
        }

        // PUT: api/RkotSum
        [HttpPut]
        public async Task<ActionResult<string>> Update([FromBody] PfbRkotSumDto item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var existing = await _context.PfbRkotSums
                    .FirstOrDefaultAsync(r => r.RsumKot == item.RsumKot && r.RsumNo == item.RsumNo);

                if (existing == null)
                    return Ok("Not Updated");

                // Update all columns like original query
                existing.RsumKds = item.RsumKds;
                existing.RsumPop = item.RsumPop;
                existing.RsumKot = item.RsumKot;
                existing.RsumDat = item.RsumDat;
                existing.RsumTbl = item.RsumTbl;
                existing.RsumTyp = item.RsumTyp;
                existing.RsumSubtbl = item.RsumSubtbl;
                existing.RsumStw = item.RsumStw;
                existing.RsumCvr = item.RsumCvr;
                existing.RsumNar = item.RsumNar;
                existing.RsumGcd = item.RsumGcd;
                existing.RsumTim = item.RsumTim;
                existing.RsumSts = item.RsumSts;
                existing.RsumCsh = item.RsumCsh;
                existing.RsumCng = item.RsumCng;
                existing.RsumEdt = item.RsumEdt;
                existing.RsumAmt = item.RsumAmt;
                existing.RsumId = item.RsumId;
                existing.RsumNo = item.RsumNo;
                existing.RsumRem = item.RsumRem;
                existing.RsumGcdName = item.RsumGcdName;
                existing.RsumBil = item.RsumBil;

                await _context.SaveChangesAsync();

                return Ok("Update Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Update failed: {ex.Message}");
            }
        }
    }
}

