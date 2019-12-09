using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITutorial
{
    public interface IMovie : IProduct
    {
        int RunningTime { get; set; }
    }
}
