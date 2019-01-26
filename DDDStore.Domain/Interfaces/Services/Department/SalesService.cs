using System;
using System.Collections.Generic;
using DDDStore.Domain.Entities;
using DDDStore.Domain.Interfaces.Repositories;

namespace DDDStore.Domain.Interfaces.Services.Department
{
    public class SalesService : ISalesService
    {
        readonly ICustomerRepository _customerRepository;
        readonly IOrderRepository _orderRepository;

        public SalesService(ICustomerRepository customerRepository, IOrderRepository orderRepository)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }

        public void AddPointsToCustomer(int customerId, int points)
        {
            var customer = _customerRepository.GetById(customerId);
            customer.UpdatePoints(points);
            _customerRepository.Update(customer);
        }

        public void IncludeSpecialDiscount(int customerId, int orderId, int discount)
        {
            var customer = _customerRepository.GetById(customerId);
            var order = _orderRepository.GetById(orderId);
            var today = DateTime.Today;

            if(today.Month == customer.DateOfBirth.Month)
            {
                order.UpdateDiscount(discount);
                _orderRepository.Update(order);
            }

        }

        public IEnumerable<Order> LoadSalesHistory(int customerId)
        {
            var customer = _customerRepository.GetById(customerId);
            return customer.Orders;
        }
    }
}
