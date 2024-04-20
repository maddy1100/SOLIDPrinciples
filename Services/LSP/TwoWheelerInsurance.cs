using BestPractices.Services.LSP.BaseClass;

namespace BestPractices.Services.LSP
{
    public class TwoWheelerInsurance : Insurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy
            return true;
        }
    }
}
