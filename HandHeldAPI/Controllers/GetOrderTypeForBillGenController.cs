using HandHeldAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetOrderTypeForBillGenController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public GetOrderTypeForBillGenController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetById/{tableNo}")]
        public async Task<ActionResult<List<string>>> GetById(string tableNo)
        {
            try
            {
                // Query RMS_RKOT_SUM for COMP type
                var record = await _context.PfbRkotSums
                    .Where(r => r.RsumTbl == tableNo
                             && r.RsumSts == "K"
                             && r.RsumTyp == "COMP")
                    .Select(r => new { r.RsumTyp, r.RsumSts })
                    .FirstOrDefaultAsync();

                var result = new List<string>();

                if (record != null)
                {
                    result.Add(record.RsumTyp); // "COMP"
                    result.Add("kuchh or data chahiye kya"); // same placeholder
                    result.Add(record.RsumSts); // "K"
                }
                else
                {
                    result.Add("GUEST");
                    result.Add("kuchh or data chahiye kya");
                    result.Add("K");
                }

                return Ok(result);
            }
            catch
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}

