using HandHeldAPI.Data;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_RBILL_SUM_BAKController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_RBILL_SUM_BAKController(HandHeldDbContext context)
        {
            _context = context;
        }

        // GET: api/CSATSU_RMS_RBILL_SUM_BAK
        [HttpGet]                                   
        public async Task<ActionResult<IEnumerable<PfbRbillSumBak>>> GetAllBills()
        {
            try
            {
                // Equivalent to: select * from RMS_RBILL_SUM
                var bills = await _context.PfbRbillSums
                    .Select(b => new PfbRbillSumBak
                    {
                        RbilPop = b.RbilPop,
                        RbilNo = b.RbilNo,
                        RbilTbl = b.RbilTbl,
                        RbilStw = b.RbilStw,
                        RbilDat = b.RbilDat
                    })
                    .ToListAsync();

                return bills;
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }

        // GET: api/CSATSU_RMS_RBILL_SUM_BAK/{pos}
        [HttpGet("{pos}")]
        public async Task<ActionResult<IEnumerable<PfbRbillSumBak>>> GetByPOS(string pos)
        {
            try
            {
                // Equivalent to:
                // SELECT * FROM RMS_RBILL_SUM b 
                // WHERE b.RBIL_POP = '{POS}'
                // AND b.RBIL_NO NOT IN (SELECT a.G_BILL FROM RMS_GUEST_COMMENT a)

                var usedBillNos = await _context.PfbGuestComments
                    .Select(a => a.GBill)
                    .ToListAsync();

                var bills = await _context.PfbRbillSums
                    .Where(b => b.RbilPop == pos && !usedBillNos.Contains(b.RbilNo))
                    .Select(b => new PfbRbillSumBak
                    {
                        RbilPop = b.RbilPop,
                        RbilNo = b.RbilNo,
                        RbilTbl = b.RbilTbl,
                        RbilStw = b.RbilStw,
                        RbilDat = b.RbilDat
                    })
                    .ToListAsync();

                return bills;
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }
    }
}
