using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Fresh : Food
    {
        private double amount;
        public double Amount { get { return amount; } set { amount = value; } }

        public Fresh(string name, double price, double amount, int btw = 6) : base (name, price, btw)
        {
            this.amount = amount;
        }
    }
}
