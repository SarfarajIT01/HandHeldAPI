using HandHeldAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandHeldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetBillTaxController : ControllerBase
    {
        private readonly HandHeldDbContext _context;

        public GetBillTaxController(HandHeldDbContext context)
        {
            _context = context;
        }

        [HttpGet("{gstName}")]
        public async Task<ActionResult<List<GstName>>> GetTaxDetails(string gstName)
        {
            if (string.IsNullOrWhiteSpace(gstName))
                return BadRequest("GstName parameter is required.");

            try
            {
                // Equivalent SQL JOINs rewritten in LINQ
                var query = from a in _context.CsatcloudTaxstructureTrns
                            join b in _context.CsatcloudTaxcodes on a.TaxCode equals b.TaxCode
                            join c in _context.CsatcloudTaxstructures on a.TaxStruCode equals c.TaxStruCode
                            where a.TaxStruCode == gstName
                            orderby a.TaxSrNo
                            select new GstName
                            {
                                TaxStruCode = a.TaxStruCode,
                                TaxSrNo = a.TaxSrNo.ToString(),
                                TaxCode = a.TaxCode,
                                Factor = a.Factor,
                                TaxOn = a.TaxOn,
                                TaxNo = a.TaxNo.ToString(),
                                TaxNoCalculatedOn = a.Calculatedon,
                                TaxName = b.TaxName,
                                TaxType = b.TaxType,
                                TaxSts = b.Taxsts,
                                //Editable = b.Editable,
                                TaxOnDisc = a.TaxOnDisc,
                                BASE = a.Base.ToString(),
                                TaxableNonTaxable = c.TaxType
                            };

                var result = await query.ToListAsync();

                return result; // same output as old API
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, new { message = "Error fetching tax details", details = ex.Message });
            }
        }
    }

    public class GstName
    {
        public string? TaxStruCode { get; set; }
        public string? TaxSrNo { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxType { get; set; }
        public string? Factor { get; set; }
        public string? TaxOn { get; set; }
        public string? TaxNo { get; set; }
        public string? TaxNoCalculatedOn { get; set; }
        public string? TaxName { get; set; }
        public string? TaxSts { get; set; }
        public string? Editable { get; set; }
        public string? TaxOnDisc { get; set; }
        public string? BASE { get; set; }
        public string? TaxableNonTaxable { get; set; }
    }
}
