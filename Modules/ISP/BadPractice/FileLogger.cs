using BestPractices.Modules.ISP.BadPractice.Interface;

namespace BestPractices.Modules.ISP.BadPractice
{
    public class FileLogger : IUtility
    {
        public bool LogData(string logdata)
        {
            //Log data to File
            return true;
        }
        public string GetDbConnStringFromConfig()
        {
            throw new NotImplementedException();
        }
        public object GetTransaction(string tranID)
        {
            throw new NotImplementedException();
        }
        public bool SaveTransaction(object tranData)
        {
            throw new NotImplementedException();
        }
    }
}
