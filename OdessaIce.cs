using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
   public class OdessaIce: IIce
    {

        private double weight;
        private string filler;

        public OdessaIce( string filler,  double weight )
        {
            this.filler = filler;
            this.Weight = weight;
        }

        public string Product { get { return "Молоко"; } } //св-во только для чтения
        public string Filler
        {
            get { return filler; }
            set { filler = value; }
        }
        public string Decor { get { return "Карамель"; } }
        public double Weight
        {
            get { return weight; }
            set {
                if (value <= 200 && value > 50)
                    weight = value;
                else
                {
                    throw new ArgumentException("Неверный вес мороженого");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Одесское мороженое включает в себя { 0}, его наполнителея является { 1}, "+
                "его вес составляет {2}, он украшен {3} ",
                Product,Filler,Weight,Decor);
        }
    }
}
