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
            Boodschappen.Add(Sportlife);
            double prijs = 0;
            Console.WriteLine(Boodschappen[0].Price);
            Console.WriteLine(Boodschappen[1].Price);
            for (int i = 0; i < Boodschappen.Count; i++)
            {
                prijs += Boodschappen[i].Price;
            }
            Console.WriteLine(prijs);
            Console.ReadLine();
            

        }
    }
}