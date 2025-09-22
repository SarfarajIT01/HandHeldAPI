using HandHeldAPI.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSATSU_RMS_GetStiwardsController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_GetStiwardsController(HandHeldDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stiwardData = await(
                from a in _context.CsatcloudEmployees
                join b in _context.PfbPersonals on a.EmpId equals b.EmpCode
                where b.EmpDesc == "STEWARD"
                select new
                {
                    b.EmpCode,
                    b.EmpName
                }
                ).ToListAsync();
            return Ok(stiwardData);
        }
    }
}
