namespace BestPractices.Services.ISP
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CreateOrder(object orderObject)
        {
            return OrderId;
        }
        public object GetOrderDetails(Guid orderId)
        {
            object OrderDetails = new object();

            return OrderDetails;
        }
    }
}
