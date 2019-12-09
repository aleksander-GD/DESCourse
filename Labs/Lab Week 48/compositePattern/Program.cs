using System;

namespace compositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicAccount ba1 = new BasicAccount(100, "Lokesh Sharma", 1000);
            BasicAccount ba2 = new BasicAccount(101, "Vinay Sharma", 2000);

            BankAccountManager basicAccountMangement = new BankAccountManager();
            basicAccountMangement.addAccount(ba1);
            basicAccountMangement.addAccount(ba2);

            PremiumAccount pa1 = new PremiumAccount(200, "Kushagra Garg", 200000, 50000);
            PremiumAccount pa2 = new PremiumAccount(200, "Vikram Sharma", 1000000, 200000);

            BankAccountManager premiumAccountManagement = new BankAccountManager();
            premiumAccountManagement.addAccount(pa1);
            premiumAccountManagement.addAccount(pa2);

            BankAccountManager accountManager = new BankAccountManager();
            accountManager.addAccount(basicAccountMangement);
            accountManager.addAccount(premiumAccountManagement);
            accountManager.PrintAccountInformation();


        }
    }
}
