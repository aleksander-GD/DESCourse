using STutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTutorial.Model
{
    public class PricePerKilogramStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Weight");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 3m / 1000;
        }
    }
    public class SpecialPriceStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Spec");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * .3m;
            int setsOfFour = item.Quantity / 4;
            total -= setsOfFour * .15m;
            return total;
        }
    }
}
