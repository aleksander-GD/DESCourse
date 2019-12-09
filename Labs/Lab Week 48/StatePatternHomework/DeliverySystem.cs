using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternHomework
{
    public class DeliverySystem
    {
        //OrderState[] states = new OrderState[] { new Created(), new Pending(), new Shipped(), new Cancelled() };
        public void HandleOrder(Order order)
        {
            order.Handle();

            //        if (order.GetState().Equals(states[0]))
            //        {
            //            order.SetState(states[1]);
            //            Console.WriteLine("Order is created");
            //        }
            //        else if (order.GetState().Equals(states[1]))
            //        {
            //            order.SetState(states[2]);
            //            Console.WriteLine("Order is pending");
            //        }
            //        else if (order.GetState().Equals(states[2]))
            //        {
            //            order.SetState(states[2]);
            //            Console.WriteLine("Order is shipped");
            //        }
            //        else
            //        {
            //            order.SetState(states[3]);
            //            Console.WriteLine("Order is cancelled");
        }
    }
}