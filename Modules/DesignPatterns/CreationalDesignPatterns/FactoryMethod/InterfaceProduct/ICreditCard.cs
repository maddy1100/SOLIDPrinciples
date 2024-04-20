namespace BestPractices.Modules.DesignPatterns.CreationalDesignPatterns.FactoryMethod
{
    // The ICreditCard interface declares the operations that all 
    // concrete products must implement.
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
