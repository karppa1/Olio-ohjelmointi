using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ruoka
    {
        public string Tyyppi { get; set; }
        public string Valmistaja { get; set; }

        public Ruoka(string tyyppi,string valmistaja)
        {
            Tyyppi = tyyppi;
            Valmistaja = valmistaja;
        }

        public override string ToString()
        {
            return "Tyyppi: " + Tyyppi + " - Valmistaja: " + Valmistaja;
        }
    }
}
