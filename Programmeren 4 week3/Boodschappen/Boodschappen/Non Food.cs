using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Non_Food : Product
    {
        private int btw;
        public int Btw { get { return btw; } set { btw = value; } }

        public Non_Food(string name, double price, int btw = 21) : base (name, price)
        {
            this.btw = btw;
        }
    }
}
