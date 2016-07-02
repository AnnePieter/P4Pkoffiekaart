using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen
{
    abstract class Product
    {
        private string name;
        private double price;
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Product(string name, double price, int btw = 0)
        {
            this.name = name;
            this.price = price;
        }
    }
}
