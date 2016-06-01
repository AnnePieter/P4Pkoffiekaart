using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    abstract class Food : Product
    {
        public decimal Btw { get; set; }

        public Food(string name, double price, decimal btw = 1.06m) : base (name, price)
        {
                this.Btw = btw;
        }
    }
}
