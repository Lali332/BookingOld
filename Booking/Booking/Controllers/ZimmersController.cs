
using Booking.Core.Entities;
using Booking.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmersController : ControllerBase
    {
        private readonly IZimmerService _zimmerService;
        public ZimmersController(IZimmerService zimmerService)
        {

            this._zimmerService = zimmerService;

        }
        // GET: api/<RentersController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_zimmerService.GetAllZimmers());
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public Zimmer Get(int zimmerCode)
        {
            return _zimmerService.GetZimmerById(zimmerCode);
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] Zimmer z)
        {
            _zimmerService.AddZimmer(z);
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Zimmer z)
        {
            _zimmerService.UpDateZimmer(id, z);
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _zimmerService.DeleteZimmer(id);

        }
    }
}
