using STutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTutorial.Model
{
    public interface IPriceStrategy
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}
