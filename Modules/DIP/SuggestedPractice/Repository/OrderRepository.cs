using BestPractices.Modules.DIP.SuggestedPractice.Interfaces;

namespace BestPractices.Modules.DIP.SuggestedPractice.Repository
{
    public class OrderRepository : IOrderRespository
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
