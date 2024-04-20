﻿using BestPractices.Modules.DIP.SuggestedPractice.Interfaces;

namespace BestPractices.Modules.DIP.SuggestedPractice
{
    public class Order
    {
        private IOrderRespository _orderRepository = null;
        public Order(IOrderRespository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public bool AddOrder(object orderDetails)
        {
            return _orderRepository.AddOrder(orderDetails);
        }
        public bool ModifyOrder(object orderDetails)
        {
            return _orderRepository.ModifyOrder(orderDetails);
        }
        public object GetOrderDetails(string orderId)
        {
            return _orderRepository.GetOrderDetails(orderId);
        }
    }
}
