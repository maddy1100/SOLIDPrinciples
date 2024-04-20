using BestPractices.Modules.ISP.SuggestedPractice.Interfaces;
namespace BestPractices.Modules.ISP.SuggestedPractice
{
    public class FileLogger : IFileLogger
    {
        public bool LogData(string logdata)
        {
            //Log data to File
            return true;
        }
    }
}
