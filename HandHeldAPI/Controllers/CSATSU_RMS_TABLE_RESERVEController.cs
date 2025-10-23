
using HandHeldAPI.Data;
using HandHeldAPI.Models.HandHeld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSATSU_RMS_TABLE_RESERVEController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public CSATSU_RMS_TABLE_RESERVEController(HandHeldDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PfbTableReserve>>> GetReservations()
        {
            try
            {
                var result = await _context.PfbTableReserves
                    .Select(r => new PfbTableReserve
                    {
                        Pos = r.Pos,
                        Bdate = r.Bdate,
                        Btime = r.Btime,
                        Rdate = r.Rdate,
                        Rtime = r.Rtime,
                        SesId = r.SesId,
                        Gcode = r.Gcode,
                        Gname = r.Gname,
                        Phone = r.Phone,
                        Gcat = r.Gcat,
                        Covers = r.Covers,
                        NoofTable = r.NoofTable,
                        ResId = r.ResId,
                        ResBy = r.ResBy,
                        SpInst = r.SpInst,
                        MsgGst = r.MsgGst,
                        ActCan = r.ActCan,
                        FinalSts = r.FinalSts,
                        ArrTime = r.ArrTime,
                        CanReason = r.CanReason,
                        TblNo = r.TblNo,
                        TabComment = r.TabComment,
                        GstSource = r.GstSource,
                        ArrComment = r.ArrComment,
                        BillComment = r.BillComment,
                        ResRefNo = r.ResRefNo
                    })
                    .ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PfbTableReserve model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                // Convert date string to yyyy-MM-dd format if needed
                DateTime bookingDate = Convert.ToDateTime(model.Bdate);
                string formattedDate = bookingDate.ToString("yyyy-MM-dd");

                // Check for existing record with same GCode and BDate
                //bool exists = await _context.PfbTableReserves
                //    .AnyAsync(r => r.Gcode == model.Gcode && r.Bdate == formattedDate);

                // Fix the comparison by ensuring both sides are of the same type (DateTime)
                bool exists = await _context.PfbTableReserves
                    .AnyAsync(r => r.Gcode == model.Gcode && r.Bdate.Value.Date == bookingDate.Date);

                if (exists)
                    return Ok("Guest Code Already Exist ..!");

                // Create new reservation entry
                var newReserve = new PfbTableReserve
                {
                    Pos = model.Pos,
                    Btime = model.Btime,
                    Rtime = model.Rtime,
                    SesId = model.SesId,
                    Gcode = model.Gcode,
                    Gname = model.Gname,
                    Phone = model.Phone,
                    Gcat = model.Gcat,
                    Covers = model.Covers,
                    NoofTable = model.NoofTable,
                    ResId = model.ResId,
                    ResBy = model.ResBy,
                    SpInst = model.SpInst,
                    MsgGst = model.MsgGst,
                    ActCan = model.ActCan,
                    FinalSts = model.FinalSts,
                    ArrTime = model.ArrTime,
                    CanReason = model.CanReason,
                    TblNo = model.TblNo,
                    TabComment = model.TabComment,
                    GstSource = model.GstSource,
                    ArrComment = model.ArrComment,
                    BillComment = model.BillComment,
                    ResRefNo = model.ResRefNo,
                    Bdate = bookingDate.Date
                };

                _context.PfbTableReserves.Add(newReserve);
                await _context.SaveChangesAsync();

                return Ok("Insert Sucessfully");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
