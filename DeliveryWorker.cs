using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
   public class DeliveryWorker
    {
        public DeliveryWorker(string fullName)
        {
            this.fullName = fullName;
        }
        string fullName;
        int salary;
        public void Hire(int salary)
        {
            this.salary = salary;
        }
        public override string ToString()
        {
            return string.Format("Работник {0}",this.fullName);
        }
    }
}
