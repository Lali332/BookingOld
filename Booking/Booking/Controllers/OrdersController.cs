using Booking.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static List<Orders> orders = new List<Orders>();
        private static int count = 1;
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            return orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Orders> Get(int id)
        {
            var order = orders.Find(e => e.codeOrder == id);
            if (order == null)
                return NotFound();
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Orders o)
        {
            orders.Add(new Orders
            {
                codeOrder = count++,
                codeZimmer = o.codeZimmer,
                tenantName = o.tenantName,
                tenantPhone = o.tenantPhone,
                orderDate = o.orderDate,
                arrivalDate = o.arrivalDate,
                departureDate = o.departureDate
            });
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Orders o)
        {
            var order = orders.Find(e => e.codeOrder == o.codeOrder);
            if (order == null)
                return NotFound();
            order.codeZimmer = o.codeZimmer;
            order.tenantName = o.tenantName;
            order.tenantPhone = o.tenantPhone;
            order.orderDate = o.orderDate;
            order.arrivalDate = o.arrivalDate;
            order.departureDate = o.departureDate;
            return Ok(order);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = orders.Find(e => e.codeOrder == id);
            if (order == null)
                return NotFound();
            orders.Remove(order);
            return Ok();
        }
    }
}