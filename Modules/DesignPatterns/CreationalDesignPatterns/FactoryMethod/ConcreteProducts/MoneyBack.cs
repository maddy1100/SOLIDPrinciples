﻿namespace BestPractices.Modules.DesignPatterns.CreationalDesignPatterns.FactoryMethod
{
    // MoneyBack Product provides implementations of the CreditCard interface methods.
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
