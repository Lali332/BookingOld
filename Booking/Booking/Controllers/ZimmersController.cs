using Booking.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmersController : ControllerBase
    {
        private static List<Zimmer> zimmers = new List<Zimmer>();
        private static int count = 1;
        // GET: api/<RentersController>
        [HttpGet]
        public IEnumerable<Zimmer> Get()
        {
            return zimmers;
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public ActionResult<Zimmer> Get(int zimmerCode)
        {
            var zimmer = zimmers.Find(e => e.codeZimmer == zimmerCode);
            if (zimmer == null)
                return NotFound();
            return zimmer;
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] Zimmer z)
        {
            zimmers.Add(new Zimmer { codeZimmer = count++,name=z.name,address=z.address,city=z.city,description=z.description,price=z.price });
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Zimmer z)
        {
            var zimmer = zimmers.Find(e => e.codeZimmer == z.codeZimmer);
            if (zimmer == null)
                return NotFound();
            zimmer.name = z.name;
            zimmer.price=z.price;
            zimmer.address=z.address;
            zimmer.city=z.city;
            zimmer.description=z.description;
            return Ok();
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var zimmer = zimmers.Find(e => e.codeZimmer == id);
            if (zimmer == null)
                return NotFound();
            zimmers.Remove(zimmer);
            return Ok();

        }
    }
}
