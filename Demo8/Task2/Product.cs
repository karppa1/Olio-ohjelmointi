using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Product
    {
        public string Tuote { get; set; }
        public double Hinta { get; set; }

        public Product(string tuote, double hinta)
        {
            Tuote = tuote;
            Hinta = hinta;
        }

        public override string ToString()
        {
            return " - product: " + Tuote + " " + Hinta + "e";
        }
    }
}
