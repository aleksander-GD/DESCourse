using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STutorial.Model
{
    public class OrderItem
    {
        public string Identifier { get; set; }
        public int Quantity { get; set; }
    }

    public class ShoppingCart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }

public enum PaymentMethod
    {
        CreditCard
    , Cheque
    }

public class PaymentDetails
    {
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardholderName { get; set; }
    }
}
