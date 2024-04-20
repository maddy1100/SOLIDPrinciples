namespace BestPractices.Modules.LSP.SuggestedPractice
{
    //Child class-2
    public class ReadConnectionFromXML : ReadConnection
    {
        public override string GetDbConnString()
        {
            string dbConn = "Connection String From XML File";
            //Read XML file to get Connection String

            dbConn = ParseServerDetails(dbConn);
            return dbConn;
        }
    }
}
