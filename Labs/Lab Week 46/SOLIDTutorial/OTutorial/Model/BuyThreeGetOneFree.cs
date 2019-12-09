using STutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTutorial.Model
{
    public class BuyThreeGetOneFree : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Buy3OneFree");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 1m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * 1m;
            return total;
        }
    }
}
