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
            double prijs = 0;

            List<Product> Boodschappen = new List<Product>();
            Preservable sportlife = new Preservable("Sportlife", 2.29);
            Non_Food paracetemol = new Non_Food("Paracetemol", 1.99);
            Fresh appels = new Fresh("Appels", 0.25,10.00);

            Boodschappen.Add(sportlife);
            Boodschappen.Add(paracetemol);
            Boodschappen.Add(appels);

            Console.WriteLine("Name" + "                    " + "Price" + " " + "Btw" + " " + "Amount" + Environment.NewLine);

            for (int i = 0; i < Boodschappen.Count; i++)
            {
                if(Boodschappen[i] is Preservable)
                {
                    Console.WriteLine(Boodschappen[i].Name + "               " + Boodschappen[i].Price + "  " + ((Food)Boodschappen[i]).Btw + "%");
                    prijs += Boodschappen[i].Price;
                }
                if (Boodschappen[i] is Non_Food)
                {
                    Console.WriteLine(Boodschappen[i].Name + "             " + Boodschappen[i].Price + "  " + ((Non_Food)Boodschappen[i]).Btw + "%");
                    prijs += Boodschappen[i].Price;
                }
                if (Boodschappen[i] is Fresh)
                {
                    Console.WriteLine(Boodschappen[i].Name + "                  " + Boodschappen[i].Price * ((Fresh)Boodschappen[i]).Amount + "   " + ((Food)Boodschappen[i]).Btw + "%" + "  " + ((Fresh)Boodschappen[i]).Amount);
                    prijs += Boodschappen[i].Price * ((Fresh)Boodschappen[i]).Amount;
                }
            }

            Console.WriteLine("                 " + "Total:"+ " " + prijs);
            Console.ReadLine();
            

        }
    }
}