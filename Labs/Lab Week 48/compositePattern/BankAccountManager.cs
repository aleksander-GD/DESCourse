using System;
using System.Collections.Generic;
using System.Text;

namespace compositePattern
{
    public class BankAccountManager : Account
    {
        private List<Account> accountsList;

        public BankAccountManager()
        {
            this.accountsList = new List<Account> { };
        }

        public void addAccount(Account account)
        {
            accountsList.Add(account);
        }
        public Boolean removeAccount(Account account)
        {
            return accountsList.Remove(account);
        }

        public void PrintAccountInformation()     
        {
            foreach (Account a in accountsList)
            {
                a.PrintAccountInformation();
            }
        }
        
        
    }
    
}
