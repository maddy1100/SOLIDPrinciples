﻿namespace BestPractices.Modules.DesignPatterns.CreationalDesignPatterns.FactoryMethod
{
    //Titanium Product provides implementations of the CreditCard interface methods.
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
