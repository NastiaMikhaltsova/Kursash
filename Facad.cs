using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
  public  class Facad
    {
        DeliveryWorker deliveryMan;
        DeliveryWorker recevingMan;
        Cars deliveryCar;
        public Facad(DeliveryWorker deliveryMan, DeliveryWorker recevingMan, Cars deliveryCar)
        {
            this.deliveryMan = deliveryMan;
            this.recevingMan = recevingMan;
            this.deliveryCar = deliveryCar;
  
        }


        public void Deliver(Order order)
        {
     
            Console.WriteLine("{0} доставляет заказ на машине {1}", deliveryMan, deliveryCar);
            Console.WriteLine("{0}принял заказ", recevingMan);

        }

    }
}
