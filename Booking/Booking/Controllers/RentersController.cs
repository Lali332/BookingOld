using Booking.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentersController : ControllerBase
    {
        private readonly DataContext context;
        public RentersController(DataContext _context)
        {

            this.context = _context;

        }
        // GET: api/<RentersController>
        [HttpGet]
        public IEnumerable<Renter> Get()
        {
            return context.RentersList;
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public ActionResult<Renter> Get(int renterCode)
        {
            var renter = context.RentersList.Find(e => e.renterCode== renterCode);
            if (renter == null)
                return NotFound();
            return renter;
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] Renter r)
        {
            context.RentersList.Add(new Renter { renterCode= context.CntRenters++,name=r.name,phone=r.phone});
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Renter r)
        {
            var renter = context.RentersList.Find(e => e.renterCode == r.renterCode);
            if (renter == null)
                return NotFound();
            renter.name = r.name;
            renter.phone = r.phone;
            return Ok();
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var renter = context.RentersList.Find(e => e.renterCode == id);
            if (renter == null)
                return NotFound();
            context.RentersList.Remove(renter);
            return Ok();

        }
    }
}
