namespace BestPractices.Modules.SRP.BadPractice
{
    public class OrderService
    {
        Guid CreateOrder(object OrderDetails)
        {
            Guid OrderId = new();
            //Code to Create Order
            return OrderId; // Return OrderId
        }
        bool MakePayment(Guid OrderId)
        {
            //Code to Make Payment
            return true; // Return Payment Status
        }
        bool GenerateInvoice(Guid OrderId)
        {
            //Code to Generate Invoice
            return true; // Return Invoice Status
        }
        bool EmailInvoice(Guid OrderId)
        {
            //Code to Email Invoice
            return true; // Return Invoice Over Email
        }
    }
}
