namespace BestPractices.Modules.ISP.SuggestedPractice.Interfaces
{
    public interface ITransactionOperations
    {
        bool SaveTransaction(object tranData);
        object GetTransaction(string tranID);
    }
}
