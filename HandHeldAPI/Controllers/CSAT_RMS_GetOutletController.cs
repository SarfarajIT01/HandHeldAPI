using HandHeldAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class CSAT_RMS_GetOutletController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HandHeldDbContext _context;

        public CSAT_RMS_GetOutletController(IConfiguration configuration, HandHeldDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOutlet()
        {
            var outletData = _context.CsatcloudOutletMsts.ToList();
            return Ok(outletData);
        }

    }
}
