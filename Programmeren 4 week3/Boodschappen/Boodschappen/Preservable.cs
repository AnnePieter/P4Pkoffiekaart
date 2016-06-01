using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Preservable : Food
    {
        public Preservable(string name, double price, decimal btw = 1.06m) : base (name, price, btw)
        {
            
        }
    }
}
