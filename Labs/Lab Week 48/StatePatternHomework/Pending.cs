using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternHomework
{
    public class Pending : OrderState
    {
        public void Handle()
        {
            Console.WriteLine("Order is pending");
        }

    }
}
