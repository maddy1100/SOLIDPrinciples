using BestPractices.Modules.ISP.SuggestedPractice.Interfaces;
namespace BestPractices.Modules.ISP.SuggestedPractice
{
    public class TransactionOperations: ITransactionOperations
    {
        public object GetTransaction(string tranID)
        {
            Object objTran = new object();
            //Retrieve Transaction

            return objTran;
        }
        public bool SaveTransaction(object tranData)
        {
            //Save Transaction

            return true;
        }
    }
}
