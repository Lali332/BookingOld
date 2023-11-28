using Booking.Core.Entities;
using Booking.Core.Services;
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
        private readonly IRenterService _renterService;
        public RentersController(IRenterService renterService)
        {

            this._renterService =renterService;

        }
        // GET: api/<RentersController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_renterService.GetAllRenters());
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public Renter Get(int renterCode)
        {
            return _renterService.GetRenterById(renterCode);
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] Renter r)
        {
            _renterService.AddRenter(r);
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Renter r)
        {
            _renterService.UpDateRenter(id,r);
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _renterService.DeleteRenter(id);

        }
    }
}
