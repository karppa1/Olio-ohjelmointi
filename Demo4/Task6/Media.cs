using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Media
    {
        public string Tyyppi { get; set; }
        public string Nimi { get; set; }

        public Media(string tyyppi,string nimi)
        {
            Tyyppi = tyyppi;
            Nimi = nimi;
        }

        public override string ToString()
        {
            return "\nTyyppi: " + Tyyppi + "\nNimi: " + Nimi;
        }

        public void printData()
        {
            Console.WriteLine("Hyllystä löytyy:" + ToString());
            Console.WriteLine();
        }
    }
}
