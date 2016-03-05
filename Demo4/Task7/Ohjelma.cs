using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Ohjelma
    {
        public string Tyyppi { get; set; }
        public string Nimi { get; set; }

        public Ohjelma(string tyyppi, string nimi)
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
            Console.WriteLine("Ohjelman tiedot:" + ToString());
            Console.WriteLine();
        }
    }
}
