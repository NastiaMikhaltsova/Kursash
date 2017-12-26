using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    class Treatment:IOrderState
    {
        public void Handle(Order order)
        {
            Console.WriteLine("Заказ{0} обрабатывается", order.Number);
            order.State = new Delivery();
        }
    }
}
