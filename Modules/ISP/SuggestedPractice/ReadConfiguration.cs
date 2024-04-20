using BestPractices.Modules.ISP.SuggestedPractice.Interfaces;
namespace BestPractices.Modules.ISP.SuggestedPractice
{
    public class ReadConfiguration : IReadConfiguration
    {
        public string GetDbConnStringFromConfig()
        {
            string dbConn = string.Empty;
            //Read Connection String From Config

            return dbConn;
        }
    }
}
