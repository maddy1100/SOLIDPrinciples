namespace BestPractices.Modules.DIP.SuggestedPractice.Interfaces
{
    public interface IOrderRespository
    {
        bool AddOrder(object orderDetails);
        bool ModifyOrder(object orderDetails);
        object GetOrderDetails(string orderId);
    }
}
