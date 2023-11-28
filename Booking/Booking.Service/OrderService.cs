using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Orders> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }
        public Orders GetOrderById(int id) 
        {
            return _orderRepository.GetOrdersById(id);
        }
        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }
        public void AddOrder(Orders order)
        {
            _orderRepository.AddOrder(order);
        }
        public void UpDateOrder(int id,Orders order)
        {
            _orderRepository.UpDateOrder(id,order);
        }
    }
}
