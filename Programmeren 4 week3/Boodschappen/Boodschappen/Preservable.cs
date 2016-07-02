using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Preservable : Food
    {
        public Preservable(string name, double price, int btw = 6) : base (name, price, btw)
        {
            
        }
    }
}
