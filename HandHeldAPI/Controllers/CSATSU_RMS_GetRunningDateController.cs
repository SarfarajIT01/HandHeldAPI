using HandHeldAPI.Data;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

//namespace CSATSU_RMS.Controllers
namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_GetRunningDateController : ControllerBase
    {
        private readonly HandHeldDbContext _context;
        private static readonly object Lock = new object();

        public CSATSU_RMS_GetRunningDateController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<PfbMst> Get()
        {
            lock (Lock)
            {
                try
                {
                    // Get the running date 
                    var rmsRecord = _context.PfbMsts
                        .AsNoTracking()
                        .Select(x => new { x.RmsStwkot, x.RmsCovkot })
                        .FirstOrDefault();

                    if (rmsRecord == null)
                    {
                        return NotFound("No RMS_MST record found");
                    }

                    return Ok(rmsRecord);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
        }
    }
}