using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class Cars
    {
        string number;
        public Cars(string number)
        {
            this.number = number;
        }
        public void Hire(string number)
        {
            this.number = number;
        }
        public void Chekup()
        {
            Console.WriteLine("Техосмотр проведён");
        }
        public void Repairs()
        {
            Console.WriteLine("Машина отремонтирована");
        }
        public override string ToString()
        {
            return string.Format("Номер машины для перевозки заказов:{0}", number);
        }
    }
}
