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
            return _context.OrdersList;
        }
        public Orders GetOrdersById(int id)
        {
            return _context.OrdersList.Find(o => o.codeOrder == id);
        }
        public void DeleteOrder(int id)
        {
            var order = _context.OrdersList.Find(o => o.codeOrder == id);          
            _context.OrdersList.Remove(order);         
        }
        public void UpDateOrder(int id ,Orders o)
        {
            var order = _context.OrdersList.Find(e => e.codeOrder == id);   
            order.codeZimmer = o.codeZimmer;
            order.tenantName = o.tenantName;
            order.tenantPhone = o.tenantPhone;
            order.orderDate = o.orderDate;
            order.arrivalDate = o.arrivalDate;
            order.departureDate = o.departureDate;
        }
        public void AddOrder(Orders o)
        {
            _context.OrdersList.Add(new Orders
            {
                codeOrder = _context.CntOrders++,
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
