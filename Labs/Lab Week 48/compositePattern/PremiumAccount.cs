using System;
using System.Collections.Generic;
using System.Text;

namespace compositePattern
{
    class PremiumAccount : Account
    {
        private int accID;
        private string name;
        private int amount;
        private int extraAmount;


        public PremiumAccount(int accID, string name, int amount, int extraAmount)
        {
            this.accID = accID;
            this.name = name;
            this.amount = amount;
            this.extraAmount = extraAmount;

        }

        public void PrintAccountInformation()
        {
            Console.WriteLine("\nName: " + name + " " + "\nAmount: " + amount + " " + "\nExtra Amount: " + extraAmount);
        }
    }
}
