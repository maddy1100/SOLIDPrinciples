using BestPractices.Services.ISP.Interfaces;

namespace BestPractices.Services.ISP
{
    public class OrderWithOnlinePayment: Order, IPaymentOnline
    {
        public bool MakePaymentByCreditCard(double amount)
        {
            //Payment Workflow as per Credit Card Payment
            return true;
        }
        public bool MakePaymentByNetBanking(double amount)
        {
            //Payment Workflow as per Online internet banking
            return true;
        }
       
    }
}
