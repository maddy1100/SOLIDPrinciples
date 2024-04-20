using BestPractices.Modules.ISP.BadPractice.Interface;

namespace BestPractices.Modules.ISP.BadPractice
{
    public class TransactionOperations : IUtility
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
        public string GetDbConnStringFromConfig()
        {
            throw new NotImplementedException();
        }
        public bool LogData(string logdata)
        {
            throw new NotImplementedException();
        }
    }
}
