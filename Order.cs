using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld
{
    public class Order
    {
        int number;
        IIce ice;
        ICake cake;
        IOrderState state;

        public Order(int number)
        {
            this.number = number;
            this.ice = null;
            this.cake = null;
            this.state = new AcceptOrder();

        }
        
        public int Number
        {
            get { return number; }
        }
        public IIce Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public ICake Cake
        {
            get { return cake; }
            set { cake = value; }
        }
        
        public IOrderState State
        {
            get { return state; }
            set { state = value; }
        }
        public void Request()
        {
            state.Handle(this);
        }


    }
}
