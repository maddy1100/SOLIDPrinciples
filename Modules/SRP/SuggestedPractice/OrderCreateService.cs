namespace BestPractices.Modules.SRP.SuggestedPractice
{
    public class OrderCreateService
    {
        Guid CreateOrder(object OrderDetails)
        {
            Guid OrderId = new();
            //Code to Create Order

            return OrderId; // Return OrderId
        }
    }
}
