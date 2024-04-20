namespace BestPractices.Modules.DIP.BadPractice.Repository
{
    public class OrderRepository
    {
        public bool AddOrder(object orderDetails)
        {
            //Save Order to Database

            return true;
        }
        public bool ModifyOrder(object orderDetails)
        {
            //Modify Order Details in Database

            return true;
        }
        public object GetOrderDetails(string orderId)
        {
            object orderDetails = new object();
            //Get Order Details from Database for given oderId

            return orderDetails;
        }
    }
}
