//using HandHeldAPI.Data;
//using HandHeldAPI.Models.CompDetail;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;

//namespace CSATSU_RMS.Controllers.CSATSU_UsageLogController
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class CSATSU_UsageLogController : ControllerBase
//    {
//        private readonly CompDetailDbContext _context; // DbContext
//        private readonly ILogger<CSATSU_UsageLogController> _logger;
//        private readonly IHttpContextAccessor _httpContextAccessor;

//        public CSATSU_UsageLogController(
//            CompDetailDbContext context,
//            ILogger<CSATSU_UsageLogController> logger,
//            IHttpContextAccessor httpContextAccessor)
//        {
//            _context = context;
//            _logger = logger;
//            _httpContextAccessor = httpContextAccessor;
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] CabsUsageLog lstobj)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            string hostname = Dns.GetHostName();
//            string retrn = "Saved Successfully";

//            // Capture clientid from header (for compatibility, even if unused)
//            string clientid = Request.Headers.ContainsKey("clientid")
//                ? Request.Headers["clientid"].FirstOrDefault()
//                : string.Empty;

//            try
//            {
//                var logEntry = new CabsUsageLog
//                {
//                    CompCode = lstobj.CompCode,
//                    ModCode = "CSATHH",
//                    UserId = lstobj.UserId,
//                    TerIpAdd = hostname,
//                    Logindate = DateTime.Now.Date,
//                    //Logintime = DateTime.Now.ToString("t"),
//                    Logintime = DateTime.Now,
//                    Logoutdate = null,
//                    Logouttime = null
//                };

//                _context.CabsUsageLogs.Add(logEntry);
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Error saving usage log.");
//                retrn = "Error saving log";
//                return StatusCode(StatusCodes.Status500InternalServerError, retrn);
//            }

//            return Ok(retrn);
//        }
//    }
//}
