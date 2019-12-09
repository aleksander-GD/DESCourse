using System;
using System.Collections.Generic;
using System.Text;

namespace compositePattern
{
    class BasicAccount : Account
    {
        private int accID;
        private string name;
        private int amount;


        public BasicAccount(int accID, string name, int amount)
        {
            this.accID = accID;
            this.name = name;
            this.amount = amount;

        }

        public void PrintAccountInformation()
        {
            
            Console.WriteLine("\nName: " + name + " " + "\nAmount: " + amount);
        }
    }
}
