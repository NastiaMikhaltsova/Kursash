using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class KievFactory:OrderFactory
    {
        int number = 1;
        public override IIce CreateIce()
        {
            return new KievIce("Присыпка", 250);
        }
        public override ICake CreateCake()
        {
            return new KievCake("Молоко", 900, "Карамель", "Ваниль");
        }
        public override Order GetOrder()
        {
            Order order = new Order(number++);
            order.Cake=this.CreateCake();
            order.Ice = this.CreateIce();
            return order;
        }
    }
}
