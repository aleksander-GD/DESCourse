using STutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTutorial.Model
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
