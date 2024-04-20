using BestPractices.Modules.DIP.BadPractice.Repository;

namespace BestPractices.Modules.DIP.BadPractice
{
    public class Order
    {
        private OrderRepository _orderRepository = null;
        public Order()
        {
            _orderRepository = new OrderRepository();
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
