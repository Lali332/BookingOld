using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }
        public Orders GetOrdersById(int id)
        {
            return _context.Orders.ToList().Find(o => o.ordersId == id);
        }
        public void DeleteOrder(int id)
        {
            var order = _context.Orders.ToList().Find(o => o.ordersId == id);          
            _context.Orders.Remove(order);         
        }
        public void UpDateOrder(int id ,Orders o)
        {
            var order = _context.Orders.ToList().Find(e => e.ordersId == id);   
            order.codeZimmer = o.codeZimmer;
            order.tenantName = o.tenantName;
            order.tenantPhone = o.tenantPhone;
            order.orderDate = o.orderDate;
            order.arrivalDate = o.arrivalDate;
            order.departureDate = o.departureDate;
        }
        public void AddOrder(Orders o)
        {
            _context.Orders.Add(new Orders
            {
                ordersId = _context.CntOrders++,
                codeZimmer = o.codeZimmer,
                tenantName = o.tenantName,
                tenantPhone = o.tenantPhone,
                orderDate = o.orderDate,
                arrivalDate = o.arrivalDate,
                departureDate = o.departureDate
            });
        }
    }
 

}
