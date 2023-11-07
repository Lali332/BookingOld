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
        private static List<Renter>renters= new List<Renter> ();
        private static int count = 1;
        // GET: api/<RentersController>
        [HttpGet]
        public IEnumerable<Renter> Get()
        {
            return renters;
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public ActionResult<Renter> Get(int renterCode)
        {
            var renter = renters.Find(e => e.renterCode== renterCode);
            if (renter == null)
                return NotFound();
            return renter;
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] Renter r)
        {
            renters.Add(new Renter { renterCode=count++,name=r.name,phone=r.phone});
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Renter r)
        {
            var renter = renters.Find(e => e.renterCode == r.renterCode);
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
            var renter = renters.Find(e => e.renterCode == id);
            if (renter == null)
                return NotFound();
            renters.Remove(renter);
            return Ok();

        }
    }
}
