using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Boodschappen = new List<Product>();
            Preservable Sportlife = new Preservable("sportlife", 2.29);
            Boodschappen.Add(Sportlife);
            Console.WriteLine(Boodschappen[0].);
            Console.ReadLine();
            

        }
    }
}