namespace BestPractices.Modules.LSP.BadPractice
{
    public class ReadConnection
    {
        public virtual string GetDbConnString()
        {
            string dbConn = "Connection String From JSON File"; //App Settings
            //Read JSON setting file to get Connection String

            dbConn = ParseServerDetails(dbConn);
            return dbConn;
        }
        public string ParseServerDetails(string DbConn)
        {
            return DbConn + " - Parsed";
        }
    }
}
