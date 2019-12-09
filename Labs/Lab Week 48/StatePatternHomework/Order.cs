using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternHomework
{
   public class Order
    {
        OrderState state;
        string product;
        double price;
        public Order(string product, double price)
        {
            this.product = product;
            this.price = price;
            this.state = new Created();
        }

        public void SetState(OrderState newState)
        {
            this.state = newState;
        }

        public OrderState GetState()
        {
            return this.state;
        }

        public void Handle()
        {
            this.state.Handle();
        }
    }
}
