//using HandHeldAPI.Models.HandHeld;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

////namespace CSATSU_RMS.Controllers
//namespace HandHeldAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CSATSU_RMS_GetRunningDateController : ControllerBase
//    {
//        private readonly HandHeldDbContext _context;
//        private static readonly object Lock = new object();

//        public CSATSU_RMS_GetRunningDateController(HandHeldDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public ActionResult<PfbMst> Get()
//        {
//            lock (Lock)
//            {
//                try
//                {
//                    // Verify clientId header is present (maintaining original behavior)
//                    if (!Request.Headers.TryGetValue("clientId", out var clientIdValues))
//                    {
//                        return BadRequest("clientId header is missing");
//                    }

//                    var clientId = clientIdValues.FirstOrDefault();
//                    if (string.IsNullOrEmpty(clientId))
//                    {
//                        return BadRequest("clientId header value is empty");
//                    }

//                    // Get the running date using EF Core LINQ
//                    var rmsRecord = _context.PfbMsts
//                        .AsNoTracking()
//                        .Select(x => new PfbMst { RmsStdate = x.RmsStdate })
//                        .FirstOrDefault();

//                    if (rmsRecord == null)
//                    {
//                        return NotFound("No RMS_MST record found");
//                    }

//                    return Ok(rmsRecord);
//                }
//                catch (Exception e)
//                {
//                    // Log the exception here (consider using ILogger)
//                    return StatusCode(StatusCodes.Status500InternalServerError);
//                }
//            }
//        }
//    }
//}