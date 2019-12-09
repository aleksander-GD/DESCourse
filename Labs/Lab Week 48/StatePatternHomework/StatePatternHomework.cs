using StatePatternHomework;
using System;

namespace DesignPatternExercise
{


    class App
    {
        public static void Main(string[] args)
        {
            Order order = new Order("Beer", 20);
            DeliverySystem ds = new DeliverySystem();
            order.Handle();
            order.SetState(new Pending());
            order.Handle();
            order.SetState(new Shipped());
            order.Handle();
            


        }
    }
}
