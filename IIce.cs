using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public interface IIce
    {
        string Product { get; } //св-во только для чтения
        string Filler { get; set; }
        string Decor { get; }
        double Weight { get; set; }
    }
}
