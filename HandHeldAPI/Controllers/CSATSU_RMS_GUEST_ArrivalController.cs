using HandHeldAPI.Data;
using HandHeldAPI.Models.DTOs;
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
    public class CSATSU_RMS_GUEST_ArrivalController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_GUEST_ArrivalController(HandHeldDbContext context)
        {
            _context = context;
        }

        // GET: api/CSATSU_RMS_GUEST_Arrival
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PfbGuestDto>>> GetAllArrivals()
        {
            try
            {
                var today = DateTime.Now.Date;

                var arrivals = await _context.PfbTableArrivals
                    .Where(a => a.ArrDate != today && (a.TableNo == "" || a.TableNo == null))
                    .Select(a => new PfbGuestDto
                    {
                        Phone1 = a.GuestId,
                        GName = a.GuestName,
                        TableNo = a.TableNo,
                        RefNo = a.RefNo
                    })
                    .ToListAsync();

                return arrivals;
            }
            catch (Exception ex)
            {
                // Optional: Log exception
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }

        // GET: api/CSATSU_RMS_GUEST_Arrival/{guest_code}
        [HttpGet("{guest_code}")]
        public async Task<ActionResult<IEnumerable<PfbGuestDto>>> GetByGuestCode(string guestCode)
        {
            try
            {
                var guests = await _context.PfbTableArrivals
                    .Where(a => a.GuestId == guestCode)
                    .Select(a => new PfbGuestDto
                    {
                        Phone1 = a.GuestId,
                        GName = a.GuestName,
                        TableNo = a.TableNo,
                        RefNo = a.RefNo
                    })
                    .ToListAsync();

                return guests;
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }
    }
}
