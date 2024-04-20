namespace BestPractices.Services.LSP.BaseClass
{
    public abstract class Insurance
    {
        public abstract bool IssuePolicy();
        public virtual bool GetPassengerCover()
        {
            return false;
        }
    }
}
