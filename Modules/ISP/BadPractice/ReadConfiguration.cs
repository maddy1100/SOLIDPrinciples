using BestPractices.Modules.ISP.BadPractice.Interface;

namespace BestPractices.Modules.ISP.BadPractice
{
    public class ReadConfiguration : IUtility
    {
        public string GetDbConnStringFromConfig()
        {
            string dbConn = string.Empty;
            //Read Connection String From Config

            return dbConn;
        }
        public object GetTransaction(string tranID)
        {
            throw new NotImplementedException();
        }
        public bool LogData(string logdata)
        {
            throw new NotImplementedException();
        }
        public bool SaveTransaction(object tranData)
        {
            throw new NotImplementedException();
        }
    }
}
