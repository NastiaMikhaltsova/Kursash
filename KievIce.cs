using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class KievIce : IIce
    {
        private double weight;
        private string decor;
        public KievIce(string decor, double weight)
        {
            this.decor = decor;
            this.Weight = weight;
        }
        public string Product { get { return "стабилизатор 293"; } } //св-во только для чтения
        public string Filler
        {
            get { return "карамель"; }
            set { throw new InvalidOperationException("Не можем сменить наполнитель Киевского мороженного"); }
        }
        public string Decor { get { return decor; } }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 50 && value <= 500)
                    weight = value;
                else
                {
                    throw new ArgumentException("Неверный вес мороженого");
                }
            }
        }
        public override string ToString()
        {
            return string.Format(
                "Киевское мороженое включает в себя {0}, его наполнителея является {1}, "+
                "его вес составляет {2}, он украшен {3} ",
                Product,Filler,Weight,Decor);
        }
    }
}
