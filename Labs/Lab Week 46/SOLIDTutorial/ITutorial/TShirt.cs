using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITutorial
{
    public class TShirt : IProduct
    {
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
    }
}
