using HandHeldAPI.Data;
using HandHeldAPI.Models.HandHeld;
using HandHeldAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_Su2LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_Su2LoginController(IConfiguration configuration, HandHeldDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpGet("{comp_code}/{p_opr_id}/{p_password}")]
        public ActionResult<CsatcloudCompanyuserid> Get(string comp_code, string p_opr_id, string p_password)
        {
            try
            {
                var loginInfo = _context.CsatcloudCompanyuserids
                    .Where(o => o.UserId == comp_code &&
                               o.UserFirstName == p_opr_id &&
                               o.UserPwd == p_password)
                    .FirstOrDefault();

                if (loginInfo == null)
                {
                    return Unauthorized("Invalid credentials");
                }

                // Create response object
                var result = new CsatcloudCompanyuserid
                {
                    UserFirstName = loginInfo.UserFirstName,
                    UserId = loginInfo.UserId,
                    Token = GlobalTokenFunction.GenerateToken($"{comp_code}#{p_opr_id}#CsatSpl37")
                };

                return Ok(result);
            }
            catch (Exception)
            {
                // Log the exception here (consider using ILogger)
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
}