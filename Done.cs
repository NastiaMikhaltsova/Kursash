using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    class Done:IOrderState
    {
        public void Handle(Order order)
        {
            Console.WriteLine("Заказ{0} получен, заказ состоит из:{1},{2}", order.Number, order.Cake, order.Ice);
            order.State = new Done();
        }
    }
}
