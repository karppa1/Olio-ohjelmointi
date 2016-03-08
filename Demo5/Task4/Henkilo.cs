using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Henkilo
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }

        public Henkilo(string nimi, int ika)
        {
            Nimi = nimi;
            Ika = ika;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + " Ikä: " + Ika;
        }
    }
}
