using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternHomework
{
    public class Shipped : OrderState
    {
        public void Handle()
        {
            Console.WriteLine("Order shipped");
        }
    }
}
