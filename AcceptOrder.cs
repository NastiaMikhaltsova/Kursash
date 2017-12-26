using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class AcceptOrder:IOrderState
    {
        public void Handle(Order order)
        {
            Console.WriteLine("Заказ принят");
            order.State = new Treatment();
        }

    }
}
