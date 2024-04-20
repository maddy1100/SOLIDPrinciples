namespace BestPractices.Services.ISP.Interfaces
{
    public interface IPaymentOnline
    {
        bool MakePaymentByCreditCard(double amount);
        bool MakePaymentByNetBanking(double amount);
    }
}
