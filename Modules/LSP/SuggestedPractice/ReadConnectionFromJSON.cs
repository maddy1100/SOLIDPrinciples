namespace BestPractices.Modules.LSP.SuggestedPractice
{
    //Child class-1
    public class ReadConnectionFromJSON : ReadConnection
    {
        public override string GetDbConnString()
        {
            string dbConn = "Connection String From JSON File";
            //Read JSON file to get Connection String

            dbConn = ParseServerDetails(dbConn);
            return dbConn;
        }
    }
}
