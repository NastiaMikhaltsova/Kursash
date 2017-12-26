using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фабрику на которой хотите 0-Одесса, 1-Киев");
            OrderFactory [] factory = new OrderFactory[2] {new KievFactory(), new OdessaFactory()};

            /* 
            int choise= Convert.ToInt32(Console.ReadLine());
            if(choise==0)
            {
                factory = new KievFactory();
            }
            else
            {
                factory = new OdessaFactory();
            }

            */

            for (int i = 0; i < 10; i++)
            {
                int choise = Convert.ToInt32(Console.ReadLine());
                Order order = factory[choise].GetOrder();
                order.Request();//метод, который определяет шаг заказ
                order.Request();
                order.Request();
                order.Request();
            }


 
        }
    }
}
