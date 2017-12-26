using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
   public class Delivery:IOrderState
    {
        Facad facad;
        
        public Delivery()
        {
            DeliveryWorker deliveryMan = new DeliveryWorker("Степан Нетудыхатко");
            deliveryMan.Hire(3000);
            DeliveryWorker recevingMan = new DeliveryWorker("Инокентий Бест");
            recevingMan.Hire(6000);
            Cars deliveryCar = new Cars("ВН5690ДР");
            facad = new Facad(deliveryMan, recevingMan, deliveryCar);

        }

        public void Handle(Order order)
        {
            Console.WriteLine("Заказ {0} доставляется", order.Number);
            facad.Deliver(order);
            order.State = new Done();
        }
    }
}
