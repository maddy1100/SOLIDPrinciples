using System.Security.Cryptography;

namespace BestPractices.Modules.LSP.SuggestedPractice
{
    // Base class
    public abstract class ReadConnection
    {
        public abstract string GetDbConnString();
        public string ParseServerDetails(string DbConn)
        {
            return DbConn + " - Parsed";
        }
    }
}
