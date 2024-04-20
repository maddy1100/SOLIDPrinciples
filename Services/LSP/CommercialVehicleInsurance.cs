using BestPractices.Services.LSP.BaseClass;

namespace BestPractices.Services.LSP
{
    public class CommercialVehicleInsurance : Insurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy

            return true;
        }
        public override bool GetPassengerCover()
        {
            return true;
        }
    }
}
