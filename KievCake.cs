using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class KievCake:ICake
    {
        private string product;
        private double weight;
        private string crem;
        private string corn;
        public KievCake(string product, double weight, string crem, string corn)
        {
            this.product = product;
            this.weight = weight;
            this.crem = crem;
            this.corn = corn;
        }
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public double Diameter { get { return 32; } }
        public double Weight
        {
            get { return weight; }
            set {
                if (value <= 800 && value > 1300)
                    weight = value;
                else
                {
                    throw new ArgumentException("Неверный вес мороженого");
                }
            }
        }
        public string Crem
        {
            get { return crem; }
            set { crem = value; }
        }
        public string Corn
        {
            get { return corn; }
            set { corn = value; }
        }
        public override string ToString()
        {
            return string.Format(
                "Киевский тортик включает в себя {0}, его наполнителея является {1}, " +
                "его вес составляет {2}, он украшен {3}, кремом ",
                Product, Corn, Weight, Crem);
        }
    }
}
