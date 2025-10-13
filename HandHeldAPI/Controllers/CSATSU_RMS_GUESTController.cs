
using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_GUESTController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_GUESTController(HandHeldDbContext context)
        {
            _context = context;
        }

        // GET: api/CSATSU_RMS_GUEST
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PfbGuestDto>>> GetAllGuests()
        {
            try
            {
                var guests = await _context.PfbGuests
                    .Take(300)
                    .Select(g => new PfbGuestDto
                    {
                        GuestCode = g.GuestCode,
                        Add1 = g.Add1,
                        GName = g.GName,
                        Phone1 = g.Phone1
                    })
                    .ToListAsync();

                return Ok(guests);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        // GET: api/CSATSU_RMS_GUEST/{guest_code}
        [HttpGet("{GuestCode}")]
        public async Task<ActionResult<IEnumerable<PfbGuestDto>>> GetById(string GuestCode)
        {
            try
            {
                var query = _context.PfbGuests.AsQueryable();

                if (!string.IsNullOrEmpty(GuestCode))
                {
                    query = query.Where(g => g.GuestCode.Contains(GuestCode));
                }

                var result = await query
                    .Take(300)
                    .Select(g => new PfbGuestDto
                    {
                        GuestCode = g.GuestCode,
                        Add1 = g.Add1,
                        GName = g.GName,
                        Phone1 = g.Phone1
                    })
                    .ToListAsync();

                if (result.Count == 0)
                    return NotFound("not found");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        // GET: api/CSATSU_RMS_GUEST/by-mobile/{MobNo}
        [HttpGet("by-mobile/{MobNo}")]
        public async Task<ActionResult<IEnumerable<PfbGuestDto>>> GetByMobile(string MobNo)
        {
            try
            {
                var guest = await _context.PfbGuests
                    .Where(g => g.Phone1.StartsWith(MobNo))
                    .Select(g => new PfbGuestDto
                    {
                        GName = g.GName,
                        Add1 = g.Add1
                    })
                    .FirstOrDefaultAsync();

                if (guest == null)
                    return NotFound("not found");

                return Ok(new List<PfbGuestDto> { guest });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        // POST: api/CSATSU_RMS_GUEST
        [HttpPost]
        public async Task<ActionResult<string>> PostGuest([FromBody] PfbGuestDto guest)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var existingGuest = await _context.PfbGuests
                    .FirstOrDefaultAsync(g => g.GuestCode == guest.GuestCode);

                if (existingGuest == null)
                {
                    // INSERT
                    var newGuest = new PfbGuest
                    {
                        GuestCode = guest.GuestCode ?? "",
                        GName = guest.GName,
                        Phone1 = guest.Phone1,
                        Add1 = guest.Add1,
                        Add2 = guest.Add2,
                        Gstin = guest.gstNo,
                        //GStatus = "A",
                        //GFO_Flag = "D"
                    };

                    _context.PfbGuests.Add(newGuest);
                    await _context.SaveChangesAsync();

                    return Ok("Insert Sucessfully");
                }
                else
                {
                    // UPDATE
                    existingGuest.GName = guest.GName;
                    existingGuest.Add1 = guest.Add1;
                    existingGuest.Add2 = guest.Add2;
                    existingGuest.Gstin = guest.gstNo;

                    _context.Entry(existingGuest).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    return Ok("Update Sucessfully");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
