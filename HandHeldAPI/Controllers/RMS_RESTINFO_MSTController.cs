//using HandHeldAPI.Data;
//using HandHeldAPI.Models.HandHeld;
//using Microsoft.AspNetCore.Mvc;

//namespace HandHeldAPI.Controllers
////namespace CSATSU_RMS.Controllers

//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RMS_RESTINFO_MSTController : ControllerBase
//    {
//        private readonly HandHeldDbContext _context;
//        private static readonly object Lock = new object();

//        public RMS_RESTINFO_MSTController(HandHeldDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<CcaComCompany>> Get()
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

//                    // Create tables if they don't exist (maintaining original behavior)
//                    //try
//                    //{
//                    //    var tableExists = _context.Database.ExecuteSqlRaw(
//                    //        "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='taxindex') " +
//                    //        "CREATE TABLE taxindex(taxstrucode nvarchar(10),taxcode nvarchar(10),ratio4tax float,ratio4taxon float,taxtype nvarchar(2),countrow int,srno int,taxsrno int,df float,actsq int)");

//                    //    tableExists = _context.Database.ExecuteSqlRaw(
//                    //        "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='taxdetail') " +
//                    //        "CREATE TABLE taxdetail(taxcode nvarchar(15),taxon float,taxamt float,taxtype nvarchar(1),taxorder nvarchar(200),taxord nvarchar(20))");

//                    //    tableExists = _context.Database.ExecuteSqlRaw(
//                    //        "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='taxsumm') " +
//                    //        "CREATE TABLE taxsumm(disc float,gentot float,genRtot float,orders nvarchar(200))");
//                    //}
//                    //catch
//                    //{
//                    //    // Silently continue as per original behavior
//                    //}

//                    // Get restaurant info
//                    var restaurantInfo = _context.CcaComCompanies
//                        //.AsNoTracking()
//                        .FirstOrDefault();

//                    if (restaurantInfo == null)
//                    {
//                        return NotFound("No restaurant information found");
//                    }

//                    return Ok(restaurantInfo);
//                }
//                catch (Exception ex)
//                {
//                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
//                }
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] CcaComCompany obj)
//        {
//            lock (Lock)
//            {
//                try
//                {
//                    if (!ModelState.IsValid)
//                    {
//                        return BadRequest(ModelState);
//                    }

//                    // Verify clientId header is present
//                    if (!Request.Headers.TryGetValue("clientId", out var clientIdValues))
//                    {
//                        return BadRequest("clientId header is missing");
//                    }

//                    var clientId = clientIdValues.FirstOrDefault();
//                    if (string.IsNullOrEmpty(clientId))
//                    {
//                        return BadRequest("clientId header value is empty");
//                    }

//                    // Verify Token header is present and valid
//                    if (!Request.Headers.TryGetValue("Token", out var tokenValues))
//                    {
//                        return BadRequest("Token header is missing");
//                    }

//                    var token = tokenValues.FirstOrDefault();
//                    var validToken = clientId + "CsatSpl37"; // Simplified for example

//                    if (token != validToken)
//                    {
//                        return Unauthorized("Invalid token");
//                    }

//                    // Check if record exists
//                    var existingRecord = _context.CcaComCompanies.FirstOrDefault();
//                    if (existingRecord == null)
//                    {
//                        return NotFound("No restaurant information found to update");
//                    }

//                    // Update properties
//                    existingRecord.CompCode = obj.CompCode;
//                    existingRecord.CompName = obj.CompName;
//                    existingRecord.CompAdd1 = obj.CompAdd1;
//                    existingRecord.CompAdd2 = obj.CompAdd2;
//                    existingRecord.CompCity = obj.CompCity;
//                    existingRecord.CompPin = obj.CompPin;
//                    existingRecord.GstinNo = obj.GstinNo;
//                    existingRecord.CompEmail = obj.CompEmail;
//                    existingRecord.CompPhone1 = obj.CompPhone1;
//                    existingRecord.CompPanNo = obj.CompPanNo;
//                    //existingRecord.REST_IMAGE2 = obj.REST_IMAGE2;
//                    //existingRecord.REST_IMAGE3 = obj.REST_IMAGE3;
//                    //existingRecord.REST_IMAGE4 = obj.REST_IMAGE4;
//                    //existingRecord.REST_IMAGE5 = obj.REST_IMAGE5;
//                    //existingRecord.REST_IMAGE6 = obj.REST_IMAGE6;
//                    //existingRecord.REST_VIDEO1 = obj.REST_VIDEO1;
//                    //existingRecord.REST_VIDEO2 = obj.REST_VIDEO2;
//                    //existingRecord.REST_VIDEO3 = obj.REST_VIDEO3;
//                    //existingRecord.REST_VIDEO4 = obj.REST_VIDEO4;
//                    //existingRecord.REST_VIDEO5 = obj.REST_VIDEO5;
//                    //existingRecord.REST_VIDEO6 = obj.REST_VIDEO6;
//                    //existingRecord.REST_LAT = obj.REST_LAT;
//                    //existingRecord.REST_QRINTERFACE = obj.REST_QRINTERFACE;

//                    _context.SaveChanges();

//                    return Ok("Updated Successfully");
//                }
//                catch (Exception ex)
//                {
//                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
//                }
//            }
//        }
//    }
//}