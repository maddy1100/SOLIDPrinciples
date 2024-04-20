namespace BestPractices.Modules.ISP.BadPractice.Interface
{
    public interface IUtility
    {
        bool LogData(string logdata);
        string GetDbConnStringFromConfig();
        bool SaveTransaction(object tranData);
        object GetTransaction(string tranID);
    }
}
