using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternHomework
{
    public class Cancelled : OrderState
    {
        public void Handle()
        {
            Console.WriteLine("Order cancelled");
        }
    }
}
