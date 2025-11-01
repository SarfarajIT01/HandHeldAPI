using HandHeldAPI.Data; 
using HandHeldAPI.Models.DTOs;
using HandHeldAPI.Models.HandHeld; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_GUEST_COMMENTController : ControllerBase
    {
        private readonly HandHeldDbContext _context;
        private readonly ILogger<CSATSU_RMS_GUEST_COMMENTController> _logger;

        public CSATSU_RMS_GUEST_COMMENTController(HandHeldDbContext context, ILogger<CSATSU_RMS_GUEST_COMMENTController> logger)
        {
            _context = context;
            _logger = logger;
        }

        //  GET: api/CSATSU_RMS_GUEST_COMMENT
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PfbGuestCommentDto>>> GetAll()
        {
            try
            {
                var list = await _context.PfbGuestComments
                    .OrderBy(c => c.GDov)
                    .Select(dr => new PfbGuestCommentDto
                    {
                        GCode = dr.GCode,
                        GDov = dr.GDov,
                        GTov = dr.GTov,
                        GBill = dr.GBill,
                        GVisitAs = dr.GVisitAs,
                        GFov = dr.GFov,
                        GNegC = dr.GNegC,
                        GPosC = dr.GPosC,
                        GComment = dr.GComment,
                        Steward = dr.Steward,
                        TableName = dr.TableName,
                        NoPax = dr.NoPax,
                        FoodQuality = dr.FoodQuality,
                        ServiceQuality = dr.ServiceQuality,
                        DiningQuality = dr.DiningQuality,
                        ReferenceBy = dr.ReferenceBy
                    })
                    .ToListAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching guest comments");
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error fetching data");
            }
        }

        // POST: api/CSATSU_RMS_GUEST_COMMENT
        [HttpPost]
        public async Task<ActionResult> PostGuestComment([FromBody] PfbGuestCommentDto model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                // Equivalent of Stime = RMS_MST.RMS_STDATE
                var rmsMst = await _context.PfbMsts.FirstOrDefaultAsync();
                DateTime stime = rmsMst?.RmsStdate ?? DateTime.Now;

                // Prevent duplicate by bill number
                bool exists = await _context.PfbGuestComments.AnyAsync(c => c.GBill == model.GBill);
                if (exists)
                    return Ok("Already Exist");

                // If same guest code exists in RMS_GUEST → remove it
                var existingGuest = await _context.PfbGuests.FirstOrDefaultAsync(g => g.GuestCode == model.GCode);
                if (existingGuest != null)
                {
                    _context.PfbGuests.Remove(existingGuest);
                    await _context.SaveChangesAsync();
                    _context.ChangeTracker.Clear(); // Clear tracked entities
                }

                // Insert into RMS_GUEST_COMMENT
                var newComment = new PfbGuestComment
                {
                    GDov = stime,
                    GTov = DateTime.Now,
                    GCode = model.GCode,
                    GBill = model.GBill,
                    GComment = model.GComment,
                    Steward = model.Steward,
                    TableName = model.TableName,
                    FoodQuality = model.FoodQuality,
                    ServiceQuality = model.ServiceQuality,
                    DiningQuality = model.DiningQuality,
                    ReferenceBy = model.ReferenceBy,
                    MResp = model.NewVisitor
                };

                _context.PfbGuestComments.Add(newComment);
                await _context.SaveChangesAsync();

                // Insert into RMS_GUEST
                try
                {
                    var guest = new PfbGuest
                    {
                        GuestCode = model.GCode,
                        GName = model.GName,
                        MDay = model.Mday,
                        Dob = model.Dob,
                        Phone1 = model.GCode,
                        Email = model.Email,
                        GSex = model.NewGender
                    };
                    _context.PfbGuests.Add(guest);
                    await _context.SaveChangesAsync();
                }
                catch
                {
                    // Fallback if DOB or M_Day missing
                    var guest = new PfbGuest
                    {
                        GuestCode = model.GCode,
                        GName = model.GName,
                        Phone1 = model.GCode,
                        Email = model.Email,
                        GSex = model.NewGender
                    };
                    _context.PfbGuests.Add(guest);
                    await _context.SaveChangesAsync();
                }

                // Insert Dynamic Ratings if any
                if (model.DynamicRating != null && model.DynamicRating.Count > 0)
                {
                    foreach (var itm in model.DynamicRating)
                    {
                        var rating = new PfbGuestRating
                        {
                            GuestId = model.GCode,
                            CcRat = itm.rating,
                            //CC_GRP = itm.group,
                            //Bill_No = model.GBill,
                            //Bill_Date = stime
                        };
                        _context.PfbGuestRatings.Add(rating);
                    }
                    await _context.SaveChangesAsync();
                }

                return Ok("Insert Successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inserting guest comment");
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
