using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Non_Food : Product
    {
        public decimal Btw { get; set; }

        public Non_Food(string name, double price, decimal btw = 1.21m) : base (name, price)
        {
            this.Btw = btw;
        }
    }
}
