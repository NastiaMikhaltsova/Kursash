using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public interface IOrderState
    {
        void Handle(Order order);
    }
}
