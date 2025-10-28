using HandHeldAPI.Data;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_GuestArrivalController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_GuestArrivalController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PfbTableReserve lstobj)
        {
            if (lstobj == null)
                return BadRequest("Invalid request data");

            try
            {
                // Check if guest already arrived today
                var today = DateTime.Now.Date;
                var existingArrival = await _context.PfbTableArrivals
                    .FirstOrDefaultAsync(a =>
                        a.GuestId == lstobj.Gcode &&
                        a.ArrDate != null &&
                        a.ArrDate.Value.Date == today);

                // If no record exists — Insert new arrival
                if (existingArrival == null)
                {
                    // Get current RMS_GstArrNo
                    var mst = await _context.PfbMsts.FirstOrDefaultAsync();
                    string gstarrno = mst?.RmsGstArrNo ?? "AR00001";

                    // Increment arrival number logic
                    var prefix = gstarrno[..2];
                    var numPart = gstarrno[2..];
                    int nextNum = int.TryParse(numPart, out var val) ? val + 1 : 1;
                    gstarrno = $"{prefix}{nextNum.ToString().PadLeft(numPart.Length, '0')}";

                    // Create new arrival entity
                    var arrival = new PfbTableArrival
                    {
                        Pos = lstobj.Pos,
                        GuestId = lstobj.Gcode,
                        GuestName = lstobj.Gname,
                        ArrDate = DateTime.Now.Date,
                        NofPax = lstobj.Covers,
                        DepTime = lstobj.Rtime,
                        RefNo = gstarrno,
                        TableNo = lstobj.TblNo,
                        ArrivalTime = "",
                        BillNo = "",
                        //ResNo = "",
                        BillAmount = 0,
                        //NofMale = "0",
                        //NofFemale = "0",
                        //NofChild = "0"
                    };

                    // Save arrival
                    _context.PfbTableArrivals.Add(arrival);

                    // Update RMS_MST1 with new number
                    if (mst != null)
                    {
                        mst.RmsGstArrNo = gstarrno;
                        _context.PfbMsts.Update(mst);
                    }

                    // Update table status to Active (A)
                    var table = await _context.PfbRmscMsts
                        .FirstOrDefaultAsync(t => t.RmscCod == lstobj.TblNo);
                    if (table != null)
                    {
                        table.RmscTblsts = "A";
                        _context.PfbRmscMsts.Update(table);
                    }

                    await _context.SaveChangesAsync();

                    return Ok("Insert Sucessfully");
                }
                else
                {
                    // If guest already exists for today — update info
                    existingArrival.TableNo = lstobj.TblNo;
                    existingArrival.ArrivalTime = "";
                    existingArrival.BillNo = "";
                    existingArrival.BillAmount = 0;
                    //existingArrival.ResNo = "";
                    //existingArrival.NofMale = "0";
                    //existingArrival.NofFemale = "0";
                    //existingArrival.NofChild = "0";

                    _context.PfbTableArrivals.Update(existingArrival);

                    // Update table status
                    var table = await _context.PfbRmscMsts
                        .FirstOrDefaultAsync(t => t.RmscCod == lstobj.TblNo);
                    if (table != null)
                    {
                        table.RmscTblsts = "A";
                        _context.PfbRmscMsts.Update(table);
                    }

                    await _context.SaveChangesAsync();

                    return Ok("Insert Sucessfully");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
