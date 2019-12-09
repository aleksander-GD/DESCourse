using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STutorial.Model;

namespace STutorial.SRP
{
    public abstract class Order
    {
        private readonly ShoppingCart _shoppingCart;
        private ShoppingCart shoppingCart;

        public Order(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        

        public ShoppingCart ShoppingCart
        {
            get
            {
                return _shoppingCart;
            }
        }

        public virtual void Checkout()
        {
            //add common functionality to all Checkout operations
        }
    }
}
