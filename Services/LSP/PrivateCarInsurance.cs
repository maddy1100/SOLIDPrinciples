using BestPractices.Services.LSP.BaseClass;

namespace BestPractices.Services.LSP
{
    public class PrivateCarInsurance : Insurance 
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy
            return true;
        }
    }
}
