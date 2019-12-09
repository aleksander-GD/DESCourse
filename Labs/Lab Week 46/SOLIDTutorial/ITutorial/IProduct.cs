using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITutorial
{
    public interface IProduct
    {
        decimal Price { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
    }
}
