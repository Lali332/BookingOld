using Booking.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext context;
        public OrdersController(DataContext _context)
        {
            context= _context;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            return context.OrdersList;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Orders> Get(int id)
        {
            var order = context.OrdersList.Find(e => e.codeOrder == id);
            if (order == null)
                return NotFound();
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Orders o)
        {
            context.OrdersList.Add(new Orders
            {
                codeOrder = context.CntOrders++,
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
            var order = context.OrdersList.Find(e => e.codeOrder == o.codeOrder);
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
            var order = context.OrdersList.Find(e => e.codeOrder == id);
            if (order == null)
                return NotFound();
            context.OrdersList.Remove(order);
            return Ok();
        }
    }
}