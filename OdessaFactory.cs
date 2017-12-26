using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class OdessaFactory:OrderFactory
    {
        int number=1;
        public override ICake CreateCake()
        {
            return new OdessaCake("Молоко", 1390, "Карамель", "Ваниль");
        }
        public override IIce CreateIce()
        {
            return new OdessaIce("Клубника", 150);       
        }
        public override Order GetOrder()
        {
            Order order = new Order(number++);
            order.Cake = this.CreateCake();
            order.Ice = this.CreateIce();
            return order;
        }
    }

}
