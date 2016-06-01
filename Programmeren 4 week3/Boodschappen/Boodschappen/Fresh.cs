using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Fresh : Food
    {
        public double Amount { get; set; }

        public Fresh(string name, double price, double amount, decimal btw = 1.06m) : base (name, price, btw)
        {
            this.Amount = amount;
        }
    }
}
