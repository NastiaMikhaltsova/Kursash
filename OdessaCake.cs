using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    class OdessaCake :ICake
    {
        private string product;
        private double weight;
        private string crem;
        private string corn;
        public OdessaCake(string product, double weight, string crem, string corn)
        {
            this.Product = product;
            this.Weight = weight;
            this.Crem = crem;
            this.Corn = corn;
        }
        public string Product
        {
            get { return product; }
            set {product= value; }
        }
        public double Diameter { get { return 40; } }
        public double Weight
        {
            get {return weight; }
            set
            {
                if (value >= 1300 && value < 2000)
                    weight = value;
                else
                {
                    throw new ArgumentException("Неверный вес торта");
                }
            }
        }
        public string Crem
        {
            get {return crem; }
            set {crem=value; }
        }
        public string Corn
        {
            get {return corn; }
            set {corn=value;}
        }
        public override string ToString()
        {
            return string.Format("Киевский тортик включает в себя {0}, его наполнителея является {1}, " +
                "его вес составляет {2}, он украшен {3}, кремом ",
                Product, Corn, Weight, Crem);
        }
    }
}
