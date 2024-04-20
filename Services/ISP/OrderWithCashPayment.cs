using BestPractices.Services.ISP.Interfaces;

namespace BestPractices.Services.ISP
{
    public class OrderWithCashPayment: Order, IPaymentOffline
    {
        public bool MakePaymentByCash(double amount)
        {
            //Make enteries that payment needs to be collected in cash on delivery

            return true;
        }
    }
}
