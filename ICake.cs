using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public interface ICake
    {
        string Product { get; set; } 
        double Diameter { get; }
        double Weight { get; set; }
        string Crem { get; set; }
        string Corn { get; set; }
    }
}
