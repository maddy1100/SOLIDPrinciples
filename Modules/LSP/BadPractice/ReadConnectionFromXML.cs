
namespace BestPractices.Modules.LSP.BadPractice
{
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
    public class Program
    {
        static void Main(string[] args)
        {
            ReadConnection readParameters = new ReadConnection();
            Console.WriteLine(readParameters.GetDbConnString());
            //Connection String From JSON File - Parsed 

            readParameters = new ReadConnectionFromXML();
            Console.WriteLine(readParameters.GetDbConnString());
            //Connection String From XML File  - Parsed 

            Console.ReadKey();
        }
    }
}
