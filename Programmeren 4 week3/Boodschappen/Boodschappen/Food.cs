using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    abstract class Food : Product
    {
        private int btw;
        public int Btw { get { return btw; } set { btw = value; } }

        public Food(string name, double price, int btw = 6) : base (name, price)
        {
            this.btw = btw;
        }
    }
}
