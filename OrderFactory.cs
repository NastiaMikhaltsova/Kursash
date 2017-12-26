using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
   public abstract class OrderFactory
    {
        public abstract IIce CreateIce();
        public abstract ICake CreateCake();
        public abstract Order GetOrder();
    }
}
